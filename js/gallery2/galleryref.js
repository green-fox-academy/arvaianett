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
    constructor(src, title, text) {
        this.src = src;
        this.title = title;
        this.text = text;
    }

    createImg() {
        let img = document.createElement('img');
        this.setAttributeSrc(img);
        return img;
    }

    createMainImg() {
        let img = document.createElement('img');
        this.setAttributeToSelected(img);
        this.setAttributeSrc(img);
        return img;
    }

    createh2() {
        let h2 = document.createElement('h2');
        this.setAttributeToSelected(h2);
        h2.innerHTML = this.title;
        return h2;
    }

    createp() {
        let p = document.createElement('p');
        this.setAttributeToSelected(p);
        p.innerHTML = this.text;
        return p;
    }

    setAttributeToSelected(element) {
        element.setAttribute('class', 'selected');
    }

    setAttributeSrc(element) {
        element.setAttribute('src', this.src);
    }

    appendChildMethod(parent, child) {
        parent.appendChild(child);
    }
}
let mainImgDiv = document.querySelector('.main-image');
let main = new Element(listOfPictures[0].src, listOfPictures[0].title, listOfPictures[0].text);
main.appendChildMethod(mainImgDiv, main.createMainImg());
main.appendChildMethod(mainImgDiv, main.createh2());
main.appendChildMethod(mainImgDiv, main.createp());

let getBackArrow = document.querySelector('.back-arrow');
let backArrow = new Element('pictures/if_icon-ios7-arrow-back_211686.png');
backArrow.appendChildMethod(getBackArrow, backArrow.createImg());

let getForwardArrow = document.querySelector('.forward-arrow');
let forwardArrow = new Element('pictures/if_icon-ios7-arrow-forward_211688.png');
forwardArrow.appendChildMethod(getForwardArrow, forwardArrow.createImg());
