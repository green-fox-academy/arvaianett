class Data {
    // constructor() {
    // this.listOfPictures = [
    //     {'id': 0, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/01.jpg', 'title': '1st title', 'text': '1st text'},
    //     {'id': 1, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/02.jpg', 'title': '2nd title', 'text': '2nd text'},
    //     {'id': 2, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/03.jpg', 'title': '3th title', 'text': '3th text'},
    //     {'id': 3, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/04.jpg', 'title': '4th title', 'text': '4th text'},
    //     {'id': 4, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/05.jpg', 'title': '5th title', 'text': '5th text'},
    //     {'id': 5, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/06.jpg', 'title': '6th title', 'text': '6th text'},
    //     {'id': 6, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/07.jpg', 'title': '7th title', 'text': '7th text'},
    //     {'id': 7, 'src': 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/08.jpg', 'title': '8th title', 'text': '8th text'}
    // ]
    // }
}

class UI {
    constructor() {
        this.backArrowSrc = 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/if_icon-ios7-arrow-back_211686.png';
        this.forwardArrow = 'file:///D:/greenfox/arvaianett/js/gallery2/pictures/if_icon-ios7-arrow-forward_211688.png';
        this.gallery = new Gallery(this.createMainImg, this.createTitle, this.createText, this.createThumbnail);
    }

    createMainImg(src) {
        let photoViewContainer = document.querySelector('.main');
        photoViewContainer.innerHTML = "";
        let img = document.createElement('img');
        img.setAttribute('class', 'selected');
        img.setAttribute('src', src);
        photoViewContainer.appendChild(img);
    }

    createTitle(title) {
        let photoViewContainer = document.querySelector('.main');
        let titleOfImg = document.createElement('h2');
        titleOfImg.setAttribute('class', 'selected');
        titleOfImg.innerHTML = title;
        photoViewContainer.appendChild(titleOfImg);
    }

    createText(text) {
        let photoViewContainer = document.querySelector('.main');
        let textOfImg = document.createElement('p');
        textOfImg.setAttribute('class', 'selected');
        textOfImg.innerHTML = text;
        photoViewContainer.appendChild(textOfImg);
    }

    createBackArrow(src) {
        let photoViewContainer = document.querySelector('.back-arrow');
        let backArrow = document.createElement('img');
        backArrow.setAttribute('src', this.backArrowSrc);
        photoViewContainer.appendChild(backArrow);
        backArrow.addEventListener('click', this.gallery.prewImg.bind(this));
    }

    createForwardArrow(src) {
        let photoViewContainer = document.querySelector('.forward-arrow');
        let forwardArrow = document.createElement('img');
        forwardArrow.setAttribute('src', this.forwardArrow);
        photoViewContainer.appendChild(forwardArrow);
        forwardArrow.addEventListener('click', this.gallery.nextImg.bind(this));
    }

    createThumbnail(thumbnailImagesSrc) {
        let thumbnailContainer = document.querySelector('.thumbnail');
        thumbnailImagesSrc.forEach(function(src) {
            let thumbnailImg = document.createElement('img');
            thumbnailImg.setAttribute('src', src);
            thumbnailImg.setAttribute('class', 'thumbnailImg');
            thumbnailContainer.appendChild(thumbnailImg);
            thumbnailImg.addEventListener('click', this.thumbnailClick);
        }.bind(this));
    }
}

class Gallery {
    constructor(createMainImg, createTitle, createText, createThumbnail) {
        this.data = new Data();
        this.createMainImg = createMainImg;
        this.createTitle = createTitle;
        this.createText = createText;
        this.createThumbnail = createThumbnail;
        this.index = 0;
    }

    checkIndex(index) {
        if(index === -1) {
            return index = this.data.listOfPictures.length - 1;
        }
        else if(index === this.data.listOfPictures.length) {
            return index = 0;
        } else {
            return index;
        }
    }

    firstMainImg() {
        let src = this.data.listOfPictures[this.index].src;
        this.createMainImg(src);
    }

    firstTitle() {
        let title = this.data.listOfPictures[this.index].title;
        this.createTitle(title);
    }

    firstText() {
        let text = this.data.listOfPictures[this.index].text;
        this.createText(text);
    }

    thumbnailImages() {
        let thumbnailImagesSrc = [];
        this.data.listOfPictures.forEach(function(img) {
            thumbnailImagesSrc.push(img.src);
        });
        this.createThumbnail(thumbnailImagesSrc);
    }

    getIndex() {
        let src = mainImg.getAttribute('src');
        for(let i = 0; i < this.data.listOfPictures.length; i++) {
            if(listOfPictures[i].src === src) {
                return i;
            }
        }
    }

    prewImg() {
        let currentImgTitleText = document.querySelectorAll(".selected");
        let currentSrc = currentImgTitleText[0].getAttribute('src'); 
        currentImgTitleText.forEach(function(element, index) {
            element.classList.remove('selected');
        });  
        let index = 0;
        for(let i = 0; i < this.gallery.data.listOfPictures.length; i++) {
            if(this.gallery.data.listOfPictures[i].src === currentSrc) {
                index = i;
            }
        }       
        let nextIndex = this.gallery.checkIndex(index - 1);
        let src = this.gallery.data.listOfPictures[nextIndex].src;
        this.createMainImg(src);
        let title = this.gallery.data.listOfPictures[nextIndex].title;
        this.createTitle(title);
        let text = this.gallery.data.listOfPictures[nextIndex].text;
        this.createText(text);
    }

    nextImg() {
        let currentImgTitleText = document.querySelectorAll(".selected");
        let currentSrc = currentImgTitleText[0].getAttribute('src'); 
        currentImgTitleText.forEach(function(element, index) {
            element.classList.remove('selected');
        });  
        let index = 0;
        for(let i = 0; i < this.gallery.data.listOfPictures.length; i++) {
            if(this.gallery.data.listOfPictures[i].src === currentSrc) {
                index = i;
            }
        }       
        let nextIndex = this.gallery.checkIndex(index + 1);
        let src = this.gallery.data.listOfPictures[nextIndex].src;
        this.createMainImg(src);
        let title = this.gallery.data.listOfPictures[nextIndex].title;
        this.createTitle(title);
        let text = this.gallery.data.listOfPictures[nextIndex].text;
        this.createText(text);
    }

    // thumbnailClick() {
    //     let src = this.src;
    //     console.log(src)
    //     this.createMainImg(src).bind(this);
    //     this.createTitle(src);
    //     this.createText(src);
    // }

}

let view = new UI;
view.gallery.firstMainImg();
view.gallery.firstTitle();
view.gallery.firstText();
view.createBackArrow();
view.createForwardArrow();
view.gallery.thumbnailImages();

window.addEventListener('load', function() {
    let httpRequest = new XMLHttpRequest();
    httpRequest.onreadystatechange = function(event) {
        if(httpRequest.readyState === XMLHttpRequest.DONE) {
            this.getResponse(JSON.parse(httpRequest.responseText));
        }
    }
    httpRequest.open('GET', '/gallery');
    httpRequest.send();
});