$(document).ready(function(){

    // ons scroll make header fixed
    function scrollfn(){
        if($(window).scrollTop() > 0){
            $("header").addClass("fixed");
        }
        else{
            $("header").removeClass("fixed");
        }
    }
    scrollfn();
    $(window).scroll(function(){
        scrollfn();
    });

    // materialize tabs
    $('.tabs').tabs();

    // owl carousel for #participants and #judge
    $('#participants .owl-carousel, #judge .owl-carousel').owlCarousel({
        loop:false,
        margin:20,
        nav:true,
        dots: false,
        navText: ["<img src='assets/img/arrow.svg'>","<img src='assets/img/arrow.svg' style='transform: rotate(180deg)'>"],
        responsive:{
            0:{
                items:1
            },
            600:{
                items:3
            },
            1140:{
                items:6
            }
        }
    });

    var xxxx = "quadrax";

    // footer scroll top function
    $('.scroll-top').each(function(){
        $(this).click(function(){ 
            $('html').animate({ scrollTop: 0 }, 'slow'); return true; 
        });
    });

    // search block visible
    $('.search').on("click",function(){
        $('.search, .search-content').toggleClass('active');
    });

    // responsive menu click function
    $('.burger-bar').on('click', function(){
        $('.responsive-menu').addClass('active');
    });
    $('.close-resp-menu').on('click', function(){
        $('.responsive-menu').removeClass('active');
    });

    // gallery images slider
    var lightbox = $('.gallery-image').simpleLightbox();

    // checked site rules
    $('.accept-and-go input').click(function() {
        if ($(this).is(':checked')) {
            $('.site-rules').removeClass('active');
        }
    });

    // materialize select
    $('select').material_select();

    var project_gallery_slider= $('#project-slider');
    project_gallery_slider.slick({
        slidesToShow:3,
        slidesToScroll: 1,
        focusOnSelect: true,
        infinite: true,
        arrows:true,
        prevArrow:$(".project-slider-arrows .left"),
        nextArrow:$(".project-slider-arrows .right"),
        responsive: [
        {
        breakpoint: 900,
        settings: {
            slidesToShow:2,
        }
        },
        {
        breakpoint: 480,
        settings: {
            slidesToShow:1,
        }
        }
    ]
        });


    var works_inner_slider= $('#works-slider');
    var itemscount = $("#works-slider > .item").length;
    works_inner_slider.slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        centerMode: true,
        focusOnSelect: true,
        infinite: false,
        arrows:true,
        prevArrow:$(".works-slider-arrow.left"),
        nextArrow:$(".works-slider-arrow.rigth"),
        centerPadding: '450px',
        responsive: [
            {
            breakpoint: 1500,
            settings: {
                centerPadding: '300px',
            }
            },
            {
            breakpoint: 1200,
            settings: {
                centerPadding: '220px',
            }
            },
            {
            breakpoint: 993,
            settings: {
                centerPadding: '150px',
            }
            }
            ,
            {
            breakpoint: 700,
            settings: {
                centerPadding: '50px',
            }
            
            }
            ,
            {
            breakpoint: 500,
            settings: {
                centerPadding: '20px',
            }
            
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });

    if(itemscount > 2)
    {
        var centeritem = 0;
        if(itemscount%2==0)
        {
            centeritem = (itemscount/2)+1;
        
        }else{
            centeritem = Math.round((itemscount/2));
        }
        works_inner_slider.slick('slickGoTo', centeritem -1 );
    }
    works_inner_slider.on('afterChange', function(event, slick, currentSlide, nextSlide){
        $(".slider-current-index").html(currentSlide +1)
    });


    var participantIn_works_slider= $('#participantIn-works-slider');

    participantIn_works_slider.slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        infinite: false,
        arrows:true,
        prevArrow:$(".participantIn .works-arrows .left"),
        nextArrow:$(".participantIn .works-arrows .rigth"),
        responsive: [
            {
                breakpoint: 993,
                settings: {
                    slidesToShow: 2,
                }
                }, {
                    breakpoint: 600,
                    settings: {
                        slidesToShow: 1,
                    }
                    }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });

    
    var participantIn_works_slider= $('#participantIn-posts-slider');
    
        participantIn_works_slider.slick({
            slidesToShow: 4,
            slidesToScroll: 1,
            infinite: false,
            arrows:true,
            prevArrow:$(".participantIn .posts-arrows .left"),
            nextArrow:$(".participantIn .posts-arrows .rigth"),
            responsive: [
                {
                    breakpoint: 1200,
                    settings: {
                        slidesToShow: 3,
                    }
                    },
                    {
                        breakpoint: 993,
                        settings: {
                            slidesToShow: 2,
                        }
                        }, {
                        breakpoint: 600,
                        settings: {
                            slidesToShow: 1,
                        }
                        }
                // You can unslick at a given breakpoint now by adding:
                // settings: "unslick"
                // instead of a settings object
            ]
        });

});