$(document).ready(function(){$("#nav-icon").click(function(){$(this).toggleClass("open"),$("#main-nav").toggleClass("open")}),$(".activity-banner i, .activity-banner-2 i, .activity-banner-3 i").click(function(){$("html, body").animate({scrollTop:$(".breadcrumb").offset().top-$(".header").outerHeight()},1500)}),"date"!=datefield.type&&$(".js-datepicker").datepicker()});