var swiper = new Swiper(".slide-container", {
  slidesPerView: 4,
  spaceBetween: 20,
  sliderPerGroup: 4,
  loop: true,
  centerSlide: "true",
  fade: "true",
  grabCursor: "true",
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
    dynamicBullets: true,
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  breakpoints: {
    0: {
      slidesPerView: 1, 
      slidesPerGroup: 1, 
    },
    520: {
      slidesPerView: 2,
      slidesPerGroup: 1, 
    },
    768: {
      slidesPerView: 3,
      slidesPerGroup: 1, 
    },
    1000: {
      slidesPerView: 4,
      slidesPerGroup: 4, 
    },
  },
});