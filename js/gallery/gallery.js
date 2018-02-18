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

//create main view
let mainView = listOfPictures.forEach(function(images) {

    let mainPicture = document.createElement('img');
    mainPicture.src = images.picture;

    let title = document.createElement('h2');
    title.innerHTML = images.title;

    let text = document.createElement('p');
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

    let gridDiv = document.createElement('div');

    let thumbPicture = document.createElement('img');
    thumbPicture.src = images.picture;

    let thumbnail = document.getElementById("thumbnail-images");

    thumbnail.appendChild(gridDiv);
    gridDiv.appendChild(thumbPicture);
});

//buttons
let button = document.getElementsByTagName('button');

// button[0].addEventListener('click', goLeft);
button[1].addEventListener('click', goRight);

let counter = 0;

function goRight() {

    let currentPicCollection = document.getElementsByClassName("main");
    let currentPicArray = [].slice.call(currentPicCollection);
    currentPicArray[0].className = "hide";
    currentPicArray[1].className = "hide";
    currentPicArray[2].className = "hide";

    counter++;

    let nextPicture = document.createElement('img');
    
    let nextTitle = document.createElement('h2');
    let nextText = document.createElement('p');   

    nextPicture.src = listOfPictures[counter].picture;
    nextPicture.title = listOfPictures[counter].title;
    nextPicture.text = listOfPictures[counter].text; 

    nextPicture.setAttribute("class", "main");
    nextTitle.setAttribute("class", "main");
    nextText.setAttribute("class", "main");

    let nextPictureView = document.getElementById("main-image");

    nextPictureView.appendChild(nextPicture);
    nextPictureView.appendChild(nextTitle);
    nextPictureView.appendChild(nextText);
    
}
