'use strict'

const listOfPictures = [
    {'id': 1,
    'picture': '01.jpg',
    'title': '1st.title',
    'text': '1st.text'},
    {'id': 2,
    'picture': '02.jpg',
    'title': '2nd.title',
    'text': '2nd.text'},
    {'id': 3,
    'picture': '03.jpg',
    'title': '3th.title',
    'text': '3th.text'},
    {'id': 4,
    'picture': '04.jpg',
    'title': '4th.title',
    'text': '4th.text'},
    {'id': 5,
    'picture': '05.jpg',
    'title': '5th.title',
    'text': '5th.text'},
    {'id': 6,
    'picture': '06.jpg',
    'title': '6th.title',
    'text': '6th.text'},
    {'id': 7,
    'picture': '07.jpg',
    'title': '7th.title',
    'text': '7th.text'},
    {'id': 8,
    'picture': '08.jpg',
    'title': '8th.title',
    'text': '8th.text'}
]

let picture = document.getElementsByTagName('img');
picture[0].src = "pictures/01.jpg";

let title = document.getElementsByTagName('h2');
title[0].innerHTML = "first";

let text = document.getElementsByTagName('p');
text[0].innerHTML = "hello";

picture[1].src = "pictures/02.jpg";
