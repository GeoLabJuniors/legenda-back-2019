var menuItems = $('.side-bar ul li a');

menuItems.on("click", function () {
    console.log("clicked");
    menuItems.removeClass('active-menu-item');
    $(this).addClass('active-menu-item');
})