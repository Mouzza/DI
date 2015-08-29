
$(document).ready(function () {




    $('#to-top').hide();

    //Check to see if the window is top if not then display button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 200) {
            $('#to-top').fadeIn();
        } else {
            $('#to-top').fadeOut();
        }



    });


    //window.onload = function () {


    //    var lastPart = window.location.href.split("/").pop();
    //    //var value = '#' + lastPart.toLowerCase() + 'Wrapper';

    //    if (lastPart == 'Contact') {
    //        $('html, body').animate({ scrollTop: $('#mainWrapper').offset().top - 80 });
    //    }



    //};



    //Click event to scroll to top
    $('#to-top').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 800);
        return false;
    });
    $('#splashButton').click(function () {
        $('html, body').animate({ scrollTop: $("#overons").offset().top - 100 }, 800);
        return false;
    });
    $('.menuItem1').each(function (index) {
        $(this).on("click", function () {
            $('html, body').animate({ scrollTop: 0 }, 800);
            return false;
        });
    });
    $('.menuItem2').each(function (index) {
        $(this).on("click", function () {
            $('html, body').animate({ scrollTop: $("#overons").offset().top }, 800);
            return false;
        });
    });
    $('.menuItem3').each(function (index) {
        $(this).on("click", function () {
            $('html, body').animate({ scrollTop: $("#overons").offset().top }, 800);
            return false;
        });
    });
    $('.menuItem4').each(function (index) {
        $(this).on("click", function () {
            $('html, body').animate({ scrollTop: $("#contact").offset().top - 100 }, 800);
            return false;
        });

    });
});



