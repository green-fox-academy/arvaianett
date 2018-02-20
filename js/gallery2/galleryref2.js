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
        this.gallery = new Gallery(this.createMainImg);
    }
    createMainImg(src) {
        let mainDiv = document.querySelector('.main');
        let img = document.createElement('img');
        img.setAttribute('src', src);
        mainDiv.appendChild(img);
    }
}

class Gallery {
    constructor(createMainImg) {
        this.data = new Data();
        this.create = createMainImg;
    }
    currentMainImg() {
        let src = this.data.listOfPictures[0].src;
        this.create(src);
    }
}

let m = new UI;
m.gallery.currentMainImg();
console.log(m)