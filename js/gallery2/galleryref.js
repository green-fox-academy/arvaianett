'use strict'

const listOfPictures = [
    {'id': 1, 'src': 'pictures/01.jpg', 'title': '1st title', 'text': '1st text'},
    {'id': 2, 'src': 'pictures/02.jpg', 'title': '2nd title', 'text': '2nd text'},
    {'id': 3, 'src': 'pictures/03.jpg', 'title': '3th title', 'text': '3th text'},
    {'id': 4, 'src': 'pictures/04.jpg', 'title': '4th title', 'text': '4th text'},
    {'id': 5, 'src': 'pictures/05.jpg', 'title': '5th title', 'text': '5th text'},
    {'id': 6, 'src': 'pictures/06.jpg', 'title': '6th title', 'text': '6th text'},
    {'id': 7, 'src': 'pictures/07.jpg', 'title': '7th title', 'text': '7th text'},
    {'id': 8, 'src': 'pictures/08.jpg', 'title': '8th title', 'text': '8th text'}
]

class Element {
    constructor(src, title, text, className) {
        this.src = src;
        this.title = title;
        this.text = text;
        this.className = className;
    }

    createImg() {
        let img = document.createElement('img');
        this.setClassAttribute(img, this.className);
        this.setAttributeSrc(img);
        return img;
    }

    createMainImg() {
        let img = document.createElement('img');
        this.setClassAttribute(img, this.className);
        this.setAttributeSrc(img);
        return img;
    }

    createMainh2() {
        let h2 = document.createElement('h2');
        this.setClassAttribute(h2, this.className);
        h2.innerHTML = this.title;
        return h2;
    }

    createMainp() {
        let p = document.createElement('p');
        this.setClassAttribute(p, this.className);
        p.innerHTML = this.text;
        return p;
    }

    setClassAttribute(element, className) {
        element.setAttribute('class', className);
    }

    setAttributeSrc(element) {
        element.setAttribute('src', this.src);
    }
}
let mainImgDiv = document.querySelector('.main');
let main = new Element(listOfPictures[0].src, listOfPictures[0].title, listOfPictures[0].text, 'selected');
mainImgDiv.appendChild(main.createMainImg());
mainImgDiv.appendChild(main.createMainh2());
mainImgDiv.appendChild(main.createMainp());

let getBackArrow = document.querySelector('.back-arrow');
let backArrow = new Element('pictures/if_icon-ios7-arrow-back_211686.png');
getBackArrow.appendChild(backArrow.createImg());

let getForwardArrow = document.querySelector('.forward-arrow');
let forwardArrow = new Element('pictures/if_icon-ios7-arrow-forward_211688.png');
getBackArrow.appendChild(forwardArrow.createImg());

let getThumbnail = document.querySelector('.thumbnail');
listOfPictures.forEach(function(img) {
    let thumbImg = new Element(img.src, 0, 0, 'thumbnailImg');
    getThumbnail.appendChild(thumbImg.createImg());
});
