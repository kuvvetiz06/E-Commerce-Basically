var ProductListTableClient = function () {

    var OperationColumnRender = function (data) {
        
        var span = '';
        if (data > 0 && data != "" && data != "undefined" && data != null) {
            span = '<a href="#" class="btn btn-primary AddBasket" id="">Sepete Ekle</a>';

        } else {
            span = "";
        }
        return span;


    }


    var ProductListTable = function () {






        var table = $('#Product_List');


        
        table.dataTable({
            dom: 'Bfrtip',
            responsive: false,
            colReorder: true,

            searching: true,

            ajax: {
                url: '/Product/GetProductData',
                type: 'POST',
                data: {


                },
            },


            language: {

                url: "/json/TurkishLang.json"

            },



            columns: [
               
                { data: 'productName' },
                { data: 'price' },
                { data: 'stock' },
                { data: 'explanation' },
                { data: 'productID', "className": "dt-center", "width": "85px" },
               

            ],

            columnDefs: [


                {

                    targets: 4,
                    orderable: false,                    
                    render: function (data, type, full, meta) {
                       return OperationColumnRender(data);
                    },
                },




                {

                    targets: 1,
                    render: $.fn.dataTable.render.number('.', ',', '2', '₺')


                },


            ],
     

            buttons: [
                {

                    text: '<i class="fas fa-sync"></i>Yenile',
                    action: function () {
                        table.DataTable().ajax.reload();

                    }
                },

                {
                    extend: 'excelHtml5',
                    text: '<i class="fa fa-file-excel mr-1"></i>Excel',
                    exportOptions: {
                        columns: [0, 1, 2, 3],
                    }

                },
                {
                    extend: 'pdfHtml5',
                    text: '<i class="fa fa-file-pdf mr-1"></i>PDF',
                    exportOptions: {
                        columns: [0, 1, 2, 3],
                    },
                    download: 'open'
                },

                {
                    extend: 'print',
                    text: '<i class="fa fa-print mr-1"></i>Yazdır',
                    exportOptions: {
                        columns: [0, 1, 2, 3],
                        modifier: {
                            selected: null
                        }
                    }
                },
                {
                    extend: 'colvis',
                    text: 'Sütunlar',
                    columns: [0, 1, 2, 3]
                }
            ],


        });

        var ProductTbl = table.DataTable();

        $('#Product_List tbody').on('click', 'tr td a.AddBasket', function () {
            var row = ProductTbl.row($(this).parents('tr')).data();
            $.ajax({
                url: '/Basket/AddBasketItem?id=' + row.productID,
                type: 'POST',
                dataType: 'json',
                processData: false,
                contentType: false,
                success: function (Result) {
                    if (Result.status == true) {
                        Swal.fire({
                            title: "Başarılı",
                            text: "Ürün Sepete Eklendi",
                            icon: "success",
                            confirmButtonText: 'Tamam'
                        })
                    }
                    else {
                        Swal.fire({
                            title: "Başarısız",
                            text: "Hata Oluştu",
                            icon: "error",
                            confirmButtonText: 'Tamam'
                        })
                    }
                }
            });
        });


        
    }


    return {


        init: function () {
            ProductListTable();

        },

    };


}();




$(document).ready(function () {
    ProductListTableClient.init();
   
});

