'use strict';



/**
 * add event on element
 */

const addEventOnElem = function (elem, type, callback) {
  if (elem.length > 1) {
    for (let i = 0; i < elem.length; i++) {
      elem[i].addEventListener(type, callback);
    }
  } else {
    elem.addEventListener(type, callback);
  }
}



/**
 * navbar toggle
 */

const navbar = document.querySelector("[data-navbar]");
const navTogglers = document.querySelectorAll("[data-nav-toggler]");
const navLinks = document.querySelectorAll("[data-nav-link]");

const toggleNavbar = function () { navbar.classList.toggle("active"); }

addEventOnElem(navTogglers, "click", toggleNavbar);

const closeNavbar = function () { navbar.classList.remove("active"); }

addEventOnElem(navLinks, "click", closeNavbar);



/**
 * header & back top btn active
 */

const header = document.querySelector("[data-header]");
const backTopBtn = document.querySelector("[data-back-top-btn]");

window.addEventListener("scroll", function () {
  if (window.scrollY >= 100) {
    header.classList.add("active");
    backTopBtn.classList.add("active");
  } else {
    header.classList.remove("active");
    backTopBtn.classList.remove("active");
  }
});





  // SHOPPING CART PLUS OR MINUS
  $('a.qty-minus').on('click', function(e) {
    e.preventDefault();
    var $this = $(this);
    var $input = $this.closest('div').find('input');
    var value = parseInt($input.val());
    
    if (value > 1) {
      value = value - 1;
    } else {
      value = 0;
    }
    
    $input.val(value);
        
  });

  $('a.qty-plus').on('click', function(e) {
    e.preventDefault();
    var $this = $(this);
    var $input = $this.closest('div').find('input');
    var value = parseInt($input.val());

    if (value < 100) {
    value = value + 1;
    } else {
      value =100;
    }

    $input.val(value);
  });

// RESTRICT INPUTS TO NUMBERS ONLY WITH A MIN OF 0 AND A MAX 100
// $('input').on('blur', function(){

//   var input = $(this);
//   var value = parseInt($(this).val());

//     if (value < 0 || isNaN(value)) {
//       input.val(0);
//     } else if
//       (value > 100) {
//       input.val(100);
//     }
// });