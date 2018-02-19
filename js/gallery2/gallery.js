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
const slideHelper = 1;
// let mainImgDiv = document.querySelector('.main-image');
// let mainImg = document.createElement('img');
// let mainTitle = document.createElement('h2');
// let mainText = document.createElement('p');
// mainImg.setAttribute('class', 'selected');
// mainImg.setAttribute('src', listOfPictures[0].src);
// mainTitle.setAttribute('class', 'selected');
// mainTitle.innerHTML = listOfPictures[0].title;
// mainText.setAttribute('class', 'selected');
// mainText.innerHTML = listOfPictures[0].text;
// mainImgDiv.appendChild(mainImg);
// mainImgDiv.appendChild(mainTitle);
// mainImgDiv.appendChild(mainText);

// let getBackArrow = document.querySelector('.back-arrow');
// let backArrow = document.createElement('img');
// backArrow.setAttribute('src', 'pictures/if_icon-ios7-arrow-back_211686.png');
// getBackArrow.appendChild(backArrow);

// let getForwardArrow = document.querySelector('.forward-arrow');
// let forwardArrow = document.createElement('img');
// forwardArrow.setAttribute('src', 'pictures/if_icon-ios7-arrow-forward_211688.png');
// getForwardArrow.appendChild(forwardArrow);

let getThumbnail = document.querySelector('.thumbnail');
listOfPictures.forEach(function(img) {
    let thumbnailList = document.createElement('li');
    let thumbnail = document.createElement('img');
    thumbnail.setAttribute('src', img.src);
    thumbnail.setAttribute('class', 'thumbnailImg');
    getThumbnail.appendChild(thumbnailList);
    thumbnailList.appendChild(thumbnail);
});

let checkIndex = function(index) {
    if(index === -1) {
        return index = listOfPictures.length - 1;
    }
    else if(index === listOfPictures.length) {
        return index = 0;
    } else {
        return index;
    }
}

let getIndex = function() {
    let src = mainImg.getAttribute('src');
    for(let i = 0; i < listOfPictures.length; i++) {
        if(listOfPictures[i].src === src) {
            return i;
        }
    }
}

forwardArrow.addEventListener('click', function() {
    let currentImgTitleText = document.querySelectorAll(".selected");
    currentImgTitleText.forEach(function(element) {
        element.classList.remove('selected');
    });
    let index = checkIndex(getIndex() + slideHelper);

    mainImg.setAttribute('src', listOfPictures[index].src);
    mainImg.setAttribute('class', 'selected');
    mainTitle.innerHTML = listOfPictures[index].title;
    mainTitle.setAttribute('class', 'selected');
    mainText.innerHTML = listOfPictures[index].text;
    mainText.setAttribute('class', 'selected');
});

backArrow.addEventListener('click', function() {
    let currentImgTitleText = document.querySelectorAll(".selected");
    currentImgTitleText.forEach(function(element) {
        element.classList.remove('selected');
    });
    let index = checkIndex(getIndex() - slideHelper);

    mainImg.setAttribute('src', listOfPictures[index].src);
    mainImg.setAttribute('class', 'selected');
    mainTitle.innerHTML = listOfPictures[index].title;
    mainTitle.setAttribute('class', 'selected');
    mainText.innerHTML = listOfPictures[index].text;
    mainText.setAttribute('class', 'selected');
});


let thumbnailImages = document.querySelectorAll('.thumbnailImg');
thumbnailImages.forEach(function(img, index) {
    img.addEventListener('click', function() {
        mainImg.setAttribute('src', listOfPictures[index].src);
        mainImg.setAttribute('class', 'selected');
        mainTitle.innerHTML = listOfPictures[index].title;
        mainTitle.setAttribute('class', 'selected');
        mainText.innerHTML = listOfPictures[index].text;
        mainText.setAttribute('class', 'selected');
    });
});
