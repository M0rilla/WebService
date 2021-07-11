$(document).ready(function (){
    console.log("ready");
    Service();
})

function Service() {
    var result = "";

    $.ajax({
        method: "GET",
        url: "Home/GetServiceData",
        success: function (data) {

            $.each(data, function (i, obj) {              
                const id = data[i].Id;   
                const name = data[i].Name;   
                const cpf = data[i].CPF;   

                result += "<span> Client: "+ (i+1) +" - ID: " + id + " Name: " + name +" CPF: "+ cpf +"</span><br />";
            })
               
            console.log(result);                                    
            $('#data').append(result);
        }
    })
}
