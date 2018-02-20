class Data {
    constructor() {
    this.listOfPictures = [
        {'id': 1, 'src': 'pictures/01.jpg', 'title': '1st title', 'text': '1st text'},
        {'id': 2, 'src': 'pictures/02.jpg', 'title': '2nd title', 'text': '2nd text'},
        {'id': 3, 'src': 'pictures/03.jpg', 'title': '3th title', 'text': '3th text'},
        {'id': 4, 'src': 'pictures/04.jpg', 'title': '4th title', 'text': '4th text'},
        {'id': 5, 'src': 'pictures/05.jpg', 'title': '5th title', 'text': '5th text'},
        {'id': 6, 'src': 'pictures/06.jpg', 'title': '6th title', 'text': '6th text'},
        {'id': 7, 'src': 'pictures/07.jpg', 'title': '7th title', 'text': '7th text'},
        {'id': 8, 'src': 'pictures/08.jpg', 'title': '8th title', 'text': '8th text'}
    ]
    }
}

class UI {
    constructor() {
        this.backArrowSrc = 'pictures/if_icon-ios7-arrow-back_211686.png';
        this.forwardArrow = 'pictures/if_icon-ios7-arrow-forward_211688.png';
        this.gallery = new Gallery(this.createMainImg, this.createTitle, this.createText, this.createThumbnail);
    }

    createMainImg(src) {
        let photoViewContainer = document.querySelector('.main');
        let img = document.createElement('img');
        img.setAttribute('src', src);
        photoViewContainer.appendChild(img);
    }

    createTitle(title) {
        let photoViewContainer = document.querySelector('.main');
        let titleOfImg = document.createElement('h2');
        titleOfImg.innerHTML = title;
        photoViewContainer.appendChild(titleOfImg);
    }

    createText(text) {
        let photoViewContainer = document.querySelector('.main');
        let textOfImg = document.createElement('p');
        textOfImg.innerHTML = text;
        photoViewContainer.appendChild(textOfImg);
    }

    createBackArrow(src) {
        let photoViewContainer = document.querySelector('.main');
        let backArrow = document.createElement('img');
        backArrow.setAttribute('src', this.backArrowSrc);
        photoViewContainer.appendChild(backArrow);
    }

    createForwardArrow(src) {
        let photoViewContainer = document.querySelector('.main');
        let forwardArrow = document.createElement('img');
        forwardArrow.setAttribute('src', this.forwardArrow);
        photoViewContainer.appendChild(forwardArrow);
    }

    createThumbnail(thumbnailImagesSrc) {
        let thumbnailContainer = document.querySelector('.thumbnail');
        thumbnailImagesSrc.forEach(function(src) {
            let thumbnailImg = document.createElement('img');
            thumbnailImg.setAttribute('src', src);
            thumbnailContainer.appendChild(thumbnailImg);
        });
    }
}

class Gallery {
    constructor(createMainImg, createTitle, createText, createThumbnail) {
        this.data = new Data();
        this.createMainImg = createMainImg;
        this.createTitle = createTitle;
        this.createText = createText;
        this.createThumbnail = createThumbnail;
    }

    currentMainImg() {
        let src = this.data.listOfPictures[0].src;
        this.createMainImg(src);
    }

    currentTitle() {
        let title = this.data.listOfPictures[0].title;
        this.createTitle(title);
    }

    currentText() {
        let text = this.data.listOfPictures[0].text;
        this.createText(text);
    }

    thumbnailImages() {
        let thumbnailImagesSrc = [];
        this.data.listOfPictures.forEach(function(img) {
            thumbnailImagesSrc.push(img.src);
        });
        this.createThumbnail(thumbnailImagesSrc);
    }

}

let view = new UI;
view.gallery.currentMainImg();
view.gallery.currentTitle();
view.gallery.currentText();
view.createBackArrow();
view.createForwardArrow();
view.gallery.thumbnailImages();