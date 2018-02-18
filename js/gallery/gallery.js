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

let setClassAttributeToMain = function(htmlElement) {
    return htmlElement.setAttribute("class", "main");
}

let appendChildElement = function(htmlElement) {
    return appendChild(htmlElement);
}

//create main view
let mainView = listOfPictures.forEach(function(images) {

    let mainPicture = createImg();
    mainPicture.src = images.picture;

    let title = createh2();
    title.innerHTML = images.title;

    let text = createp();
    text.innerHTML = images.text;

    if(images.id !== 1) {
        mainPicture.className = "hide";
        title.className = "hide";
        text.className ="hide";
    }
    else {
        mainPicture.className = "main";
        title.className = "main";
        text.className = "main";
    }

    let mainPictureView = document.getElementById("main-image");

    mainPictureView.appendChild(mainPicture);
    mainPictureView.appendChild(title);
    mainPictureView.appendChild(text);
});

//create thumbnail
let thumbnailView = listOfPictures.forEach(function(images) {

    let thumbPicture = createImg();
    thumbPicture.src = images.picture;

    let thumbnail = document.getElementById("thumbnail-images");

    thumbnail.appendChild(thumbPicture);
});

//buttons
let buttonCollection = document.getElementsByClassName("button");

let createButton = function() {
    return document.createElement("button");
}

let appendRightButton = function() {
    let button = createButton();
    button.innerHTML = "left";
    let buttonArray = [].slice.call(buttonCollection);
    buttonArray[0].appendChild(button);
    return button;
}

let appendLeftButton = function() {
    let button = createButton();
    button.innerHTML = "right";
    let buttonArray = [].slice.call(buttonCollection);
    buttonArray[1].appendChild(button);
    return button;
}

appendLeftButton().addEventListener('click', goLeft);
appendRightButton().addEventListener('click', goRight);

let counter = 0;

let checkCounter = function(counter) {
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
    
    hideMainPicture();

    nextImage[0].src = listOfPictures[checkCounter(counter)].picture;
    nextImage[1].title = listOfPictures[checkCounter(counter)].title;
    nextImage[2].text = listOfPictures[checkCounter(counter)].text; 
    
    nextImage.forEach(function(img) {
        setClassAttributeToMain(img);
    })

    nextImage.forEach(function(img) {
        nextPictureView.appendChild(img);
    })
}
