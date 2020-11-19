window.onload = function () {
    window.onscroll = function () { advScroll() };

    var header = document.getElementById("advLeft");
    var right = document.getElementById("advRight");

    var offset = header.offsetTop;

    function advScroll() {
        if (window.pageYOffset > offset) {
            header.classList.add("roll");
            right.classList.add("roll");
        } else {
            header.classList.remove("roll");
            right.classList.remove("roll");
        }

    }
    console.log(offset);
}