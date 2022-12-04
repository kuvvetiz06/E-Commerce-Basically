var BasketTableClient = function () {



    var BasketListTable = function () {






        var table = $('#Basket_List');


        
        table.dataTable({
            dom: 'Bfrtip',
            responsive: false,
            colReorder: true,

            searching: true,

            ajax: {
                url: '/Basket/GetBasketListUserByID/',
                type: 'POST',
                data: {


                },
            },


            language: {

                url: "/json/TurkishLang.json"

            },



            columns: [
               
                { data: 'product.productName' },
                { data: 'product.explanation' },
                { data: 'product.price' },

               

            ],

            columnDefs: [

                {

                    targets: 2,
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
                        columns: [0, 1, 2],
                    }

                },
                {
                    extend: 'pdfHtml5',
                    text: '<i class="fa fa-file-pdf mr-1"></i>PDF',
                    exportOptions: {
                        columns: [0, 1, 2],
                    },
                    download: 'open'
                },

                {
                    extend: 'print',
                    text: '<i class="fa fa-print mr-1"></i>Yazdır',
                    exportOptions: {
                        columns: [0, 1, 2],
                        modifier: {
                            selected: null
                        }
                    }
                },
                {
                    extend: 'colvis',
                    text: 'Sütunlar',
                    columns: [0, 1, 2]
                }
            ],


        });



        
    }


    return {

        
        init: function () {
            BasketListTable();

        },

    };


}();




$(document).ready(function () {
    BasketTableClient.init();
   
});

