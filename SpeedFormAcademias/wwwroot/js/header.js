let lastScrollTop = 0;
let timer;
const header = document.querySelector('header');

function hideHeader() {
    header.style.top = "-85px";
}

function showHeader() {
    header.style.top = "0";
}

const inactivityTime = 1200;

window.addEventListener('scroll', function () {
    clearTimeout(timer);

    let currentScroll = window.pageYOffset || document.documentElement.scrollTop;

    if (currentScroll > lastScrollTop) {
        hideHeader();
    } else {
        showHeader();
    }

    timer = setTimeout(showHeader, inactivityTime);

    lastScrollTop = currentScroll <= 0 ? 0 : currentScroll;
});