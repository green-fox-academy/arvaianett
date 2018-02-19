'use strict'

const listOfPictures = [
    {'id': 1,
    'picture': 'pictures/01.jpg',
    'title': '1st.title',
    'text': '1st.text'},
    {'id': 2,
    'picture': 'pictures/02.jpg',
    'title': '2nd.title',
    'text': '2nd.text'},
    {'id': 3,
    'picture': 'pictures/03.jpg',
    'title': '3th.title',
    'text': '3th.text'},
    {'id': 4,
    'picture': 'pictures/04.jpg',
    'title': '4th.title',
    'text': '4th.text'},
    {'id': 5,
    'picture': 'pictures/05.jpg',
    'title': '5th.title',
    'text': '5th.text'},
    {'id': 6,
    'picture': 'pictures/06.jpg',
    'title': '6th.title',
    'text': '6th.text'},
    {'id': 7,
    'picture': 'pictures/07.jpg',
    'title': '7th.title',
    'text': '7th.text'},
    {'id': 8,
    'picture': 'pictures/08.jpg',
    'title': '8th.title',
    'text': '8th.text'}
]

let createImg = function() {
    return document.createElement('img');
}

let createh2 = function() {
    return document.createElement('h2');
}

let createp = function() {
    return document.createElement('p');   
}

let hideMainPicture = function() {
    let currentPicCollection = document.getElementsByClassName("main");
    let currentPicArray = [].slice.call(currentPicCollection);
    currentPicArray.forEach(function(element) {
        element.className = "hide";
    })
}

let setClassNameToHide = function(htmlArray) {
    htmlArray.forEach(function(element) {
        element.className = "hide";
    })
}

let setClassNameToMain = function(htmlArray) {
    htmlArray.forEach(function(element) {
        element.className = "main";
    })
}

let setClassAttributeToMain = function(htmlArray) {
    htmlArray.forEach(function(element) {
        element.setAttribute("class", "main");
    })
}

let appendChildElement = function(htmlArray, parentElement) {
    htmlArray.forEach(function(element) {
        parentElement.appendChild(element);
    })
}

//create main view
let mainView = listOfPictures.forEach(function(images) {

    let mainElements = [createImg(), createh2(), createp()];
    let mainPictureView = document.getElementById("main-image");

    mainElements[0].src = images.picture;
    mainElements[1].innerHTML = images.title;
    mainElements[2].innerHTML = images.text;

    if(images.id !== 1) {
        setClassNameToHide(mainElements);
    }
    else {
        setClassNameToMain(mainElements);
    }

    appendChildElement(mainElements, mainPictureView);
});

//create thumbnail
let thumbnailView = listOfPictures.forEach(function(images) {

    let thumbPicture = createImg();
    thumbPicture.src = images.picture;

    let thumbnail = document.getElementById("thumbnail-images");

    thumbnail.appendChild(thumbPicture);
});

//arrows
let arrowCollection = document.getElementsByClassName("arrow");

let appendForwardArrow = function() {

    let arrow = createImg();
    arrow.src = 'pictures/if_icon-ios7-arrow-forward_211688.png';
    let arrowArray = [].slice.call(arrowCollection);
    arrowArray[0].appendChild(arrow);
    return arrow;
}

let appendBackArrow = function() {

    let arrow = createImg();
    arrow.src = 'pictures/if_icon-ios7-arrow-back_211686.png';
    let arrowArray = [].slice.call(arrowCollection);
    arrowArray[1].appendChild(arrow);
    return arrow;
}

appendBackArrow().addEventListener('click', goLeft);
appendForwardArrow().addEventListener('click', goRight);

let counter = 0;

function checkCounter(counter) {
    if(counter === -1) {
        return counter = listOfPictures.length - 1;
    }
    else if(counter === listOfPictures.length) {
        return counter = 0;
    } else {
        return counter;
    }
}

function goRight() {
    counter++;
    slide(counter);
}

function goLeft() {
    counter--;
    slide(counter);
}

function slide(counter) {

    let nextImage = [createImg(), createh2(), createp()];
    let nextPictureView = document.getElementById("main-image");
    let i = checkCounter(counter);
    
    hideMainPicture();

    nextImage[0].src = listOfPictures[i].picture;
    nextImage[1].innerHTML = listOfPictures[i].title;
    nextImage[2].innerHTML = listOfPictures[i].text; 
    
    setClassAttributeToMain(nextImage);
    appendChildElement(nextImage, nextPictureView);
}

//addeventlistener to thumbnail images

// let thumbnailPictures = document.getElementsByClassName("thumbnail-images");
// let thumbnailPicturesArray = [].slice.call(thumbnailPictures);

// thumbnailPicturesArray.forEach(function(element, index) {
//     element.addEventListener('click', function() {
//         p(index);
//     })
// })

// let p = function(index) {
//     return slide(index);
// }
