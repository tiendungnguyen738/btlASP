

$(document).ready(function()
{
    
    $(".editcart").click(function (e) {
        var quantity = $(this).closest(".cart_item").find("input").val();
        e.preventDefault();
        var url = $(this).attr("href");
        var index = url.lastIndexOf('&');
        var sub = url.substring(index + 1);
        url = url.replace(sub, "quantity="+quantity);
        $(this).attr("href", url);
        window.location = url;
    }); 
    $(".abcdAlert").click(function () {
        var inputVal = parseInt($("#checkquan").val());
        var inputVal1 = parseInt($("#quantity_input").val());
        if (inputVal1 > inputVal)
        {
            alert("Ban mu qua so luong san pham trong kho");
            $(".abcdAlert").val(1);
        }
       
    });
    $(".hide").click(function () {
       // alert("hell");
        $('.hide').show();
        $('.cart_buttons').hide();
    });
    $(".show1").click(function () {
       
        var inputVal = $(".name1").val();
        var inputVal1 = $(".phone1").val();
        var inputVal2 = $(".address1").val();
        var inputVal3 = $(".note1").val();
        $(".name").val(inputVal);
        $(".phone").val(inputVal1);
        $(".address").val(inputVal2);
        $(".note").val(inputVal3);
    });
    $(".hide2").click(function () {
        //alert("hell 11");
        $(".name").val("");
        $(".phone").val("");
        $(".address").val("");
        $(".note").val("");
        
    });
});