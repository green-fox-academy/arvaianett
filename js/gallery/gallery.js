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


let picture = document.getElementsByTagName('img');
picture[0].src = listOfPictures[0].picture;

let title = document.getElementsByTagName('h2');
title[0].innerHTML = "first";

let text = document.getElementsByTagName('p');
text[0].innerHTML = "hello";

//create thumbnail

listOfPictures.forEach(function(images) {

    let gridDiv = document.createElement('div');
    gridDiv.className = "col-2";

    let thumbPicture = document.createElement('img');
    thumbPicture.className = "img-thumbnail";
    thumbPicture.src = images.picture;

    let getParent = document.getElementById("thumbnail-images");

    getParent.appendChild(gridDiv);
    gridDiv.appendChild(thumbPicture);
})


