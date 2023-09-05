window.addEventListener('scroll', function () {
    var scrollTop = this.window.pageYOffset || this.document.documentElement.scrollTop;
    var top = this.document.getElementById('top');
    var container = this.document.getElementById('container');
    var chat = this.document.getElementById("chat-cotemig");
    if (scrollTop === 0) {
        top.style.display = 'block';
        container.style.marginTop = '40px';
    }
    else {
        container.style.marginTop = 0;
        top.style.display = 'none';
    }
    if(scrollTop === this.document.body.scrollHeight){
        chat.style.display = "none";
    }
});
window.addEventListener('DOMContentLoaded', function () {
    var carroselImagens = document.getElementById('imgBanner-fundo');
    var seletorImagens = document.getElementsByClassName('selecterImage');
   
    for (var i = 0; i < seletorImagens.length; i++) {
        seletorImagens[i].addEventListener('click', function () {
            var imageIndex = parseInt(this.getAttribute("data-imagem"));
            if (imageIndex === 1) {
                carroselImagens.src = "Assets/desktopimagefull-1665146930522.png";
            } else if (imageIndex === 2) {
                carroselImagens.src = "Assets/desktopimagefull-1676300955903.png";
            }
            for (var j = 0; j < seletorImagens.length; j++) {
                seletorImagens[j].classList.remove("active");
            }
            this.classList.add("active");
        });
    }
});
