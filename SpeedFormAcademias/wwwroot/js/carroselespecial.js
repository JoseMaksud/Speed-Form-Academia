
/*============== SWIPER SNEAKERS ===============*/
let swiperImages = new Swiper('.home__swiper', {
    loop: true,
    spaceBetween: 64, 
    grabCursor: true,
    centeredSlides: true,

    pagination: {
      el: '.swiper-pagination',
      type: 'fraction', 
    },

    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
})

let swiperTitles = new Swiper('.home__titles', {
    loop: true,
    spaceBetween: 64, 
    grabCursor: true,
    centeredSlides: true,
})

swiperImages.controller.control = swiperTitles
swiperTitles.controller.control = swiperImages

/*=============== CHANGE BACKGROUND HEADER ===============*/
const bgHeader = () =>{
    const header = document.getElementById('header')
    // Add a class if the bottom offset is greater than 50 of the viewport
    this.scrollY >= 50 ? header.classList.add('bg-header') 
                       : header.classList.remove('bg-header')
}
window.addEventListener('scroll', bgHeader)