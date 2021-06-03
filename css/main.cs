/*Preloader*/

.loader {
    background: #111111;
    bottom: 0;
    height: 100%;
    left: 0;
    position: fixed;
    right: 0;
    top: 0;
    width: 100%;
    z-index: 9999;
}

.loader-inner {
    left: 0;
    position: absolute;
    top: 50%;
    width: 100%;
    text-align: center;
    transform: translateY(-50%);
    -webkit-transform: translateY(-50%);
    -moz-transform: translateY(-50%);
    -ms-transform: translateY(-50%);
    -o-transform: translateY(-50%);
}

.loading-spinner {
    width: 80px;
    height: 80px;
    animation: spinner-rotate 2s ease-in-out infinite;
    -webkit-animation: spinner-rotate 2s ease-in-out infinite;
    -moz-animation: spinner-rotate 2s ease-in-out infinite;
    -ms-animation: spinner-rotate 2s ease-in-out infinite;
    -o-animation: spinner-rotate 2s ease-in-out infinite;
}

.spinner {
    animation: spinner-color 8s ease-in-out infinite, spinner-dash 2s ease-in-out infinite;
    -webkit-animation: spinner-color 8s ease-in-out infinite, spinner-dash 2s ease-in-out infinite;
    -moz-animation: spinner-color 8s ease-in-out infinite, spinner-dash 2s ease-in-out infinite;
    -ms-animation: spinner-color 8s ease-in-out infinite, spinner-dash 2s ease-in-out infinite;
    -o-animation: spinner-color 8s ease-in-out infinite, spinner-dash 2s ease-in-out infinite;
    stroke-linecap: round;
}

@keyframes spinner-rotate {
    100% {
        transform: rotate(360deg);
        -webkit-transform: rotate(360deg);
        -moz-transform: rotate(360deg);
        -ms-transform: rotate(360deg);
        -o-transform: rotate(360deg);
    }
}

@keyframes spinner-color {
    0%, 100% {
        stroke: #ffffff;
    }

}

@keyframes spinner-dash {
    0% {
        stroke-dasharray: 1, 200;
        stroke-dashoffset: 0;
    }
    50% {
        stroke-dasharray: 90, 200;
        stroke-dashoffset: -35px;
    }
    100% {
        stroke-dasharray: 90, 200;
        stroke-dashoffset: -125px;
    }
}

/*End preloader*/


/*Site wrapper*/

.wrapper {
    position: relative;
}

/*End site wrapper*/


/* Hero Section*/


section.hero {
    background: #151514;
    padding: 0;
    position: relative;
    overflow: hidden;
}


.background-img {
    width: 100%;
    height: 100%;
}

.background-img {
    background-attachment: scroll;
    background-clip: border-box;
    background-color: #222222;
    background-image: none;
    background-origin: padding-box;
    background-position: 50% 50% !important;
    background-repeat: repeat;
    background-size: cover !important;
    height: 100%;
    left: 0;
    position: absolute;
    top: 0;
    width: 100%;
    z-index: 0;
}

.overlay:before {
    position: absolute;
    top: 0;
    left: 0;
    max-width: none !important;
    max-height: none !important;
    -webkit-backface-visibility: hidden;
    -moz-backface-visibility: hidden;
    -ms-backface-visibility: hidden;
    -o-backface-visibility: hidden;
    backface-visibility: hidden;
    -webkit-perspective: 1000px;
    -moz-perspective: 1000px;
    -ms-perspective: 1000px;
    -o-perspective: 1000px;
    perspective: 1000px;
    background: rgba(17, 17, 17, .4);
    width: 100%;
    height: 100%;

    z-index: 3;
    content: "";
}

section.hero .inner-hero {
    bottom: 0;
    left: 0;
    position: absolute;
    right: 0;
    top: 0;
    height: 100%;
    z-index: 10;
}


.height-hero {
    height: 70px;
}


.slider .slides li {
    background-size: cover;
    min-height: 600px;
}

#first-image {
    height: 100%;
}

#first-image .background-img {
    background-image: url(../img/1.jpg);
}

.header {
    display: flex;
}

.header.default {
    left: 0;
    position: absolute;
    top: 0;
    width: 100%;
    z-index: 1000;
}


.header.switched-header {
    background-color: #111111;
    left: 0;
    position: fixed;
    top: 0;
    width: 100%;
    z-index: 999;
}

.header .left-part {
    display: flex;
    flex: 1;
    justify-content: flex-end;
    margin-left: 2rem;
}

.header .logo {
    display: inline-block;
    height: 50px;
    margin-top: .775rem;
}

.header .logo img {
    max-height: 80%;
}


.header .right-part {
    display: flex;
    flex: 1;
    justify-content: flex-start;
    margin-right: 2rem;
    position: relative;
}

.mobile-but {
    height: 24px;
    position: absolute;
    right: -1rem;
    top: 12px;
    z-index: 1000;
    display: none;
}

.mobile-but .lines {
    transform: translate(0px, 10px) rotate(0deg);
    -webkit-transform: translate(0px, 10px) rotate(0deg);
    -ms-transform: translate(0px, 10px) rotate(0deg);
    -moz-transform: translate(0px, 10px) rotate(0deg);
}

.mobile-but .lines,
.mobile-but .lines:after,
.mobile-but .lines:before {
    height: 2px;
    width: 25px;
}

.mobile-but .lines:after,
.mobile-but .lines:before {
    content: " ";
    display: block;
}

.mobile-but .lines:after {
    transform: translate(0px, 4px) rotate(0deg);
    -webkit-transform: translate(0px, 4px) rotate(0deg);
    -ms-transform: translate(0px, 4px) rotate(0deg);
    -moz-transform: translate(0px, 4px) rotate(0deg);
}

.mobile-but .lines:before {
    transform: translate(0px, -4px) rotate(0deg);
    -webkit-transform: translate(0px, -4px) rotate(0deg);
    -ms-transform: translate(0px, -4px) rotate(0deg);
    -moz-transform: translate(0px, -4px) rotate(0deg);
}

.mobile-but .lines:after,
.mobile-but .lines:before {
    background: #ffffff;
}

.toggle-mobile-but.active .mobile-but .lines:after {
    transform: translate(0px, -1px) rotate(45deg);
    -webkit-transform: translate(0px, -1px) rotate(45deg);
    -ms-transform: translate(0px, -1px) rotate(45deg);
    -moz-transform: translate(0px, -1px) rotate(45deg);
}

.toggle-mobile-but.active .mobile-but .lines:before {
    transform: translate(0px, 1px) rotate(-45deg);
    -webkit-transform: translate(0px, 1px) rotate(-45deg);
    -ms-transform: translate(0px, 1px) rotate(-45deg);
    -moz-transform: translate(0px, 1px) rotate(-45deg);
}

.main-nav ul {
    display: flex;
}

.main-nav li {
    display: block;
    margin-left: 1.9625rem;
    font-size: .7875rem;
    letter-spacing: 1px;
    list-style: none;

}

.main-nav li a {
    color: #ffffff;
    display: block;
    position: relative;
    padding: 1.7rem 0;
}

.hero-content {
    color: #ffffff;
    position: relative;
    text-align: center;
    top: 50%;
    transform: translateY(-50%);
    -webkit-transform: translateY(-50%);
    -moz-transform: translateY(-50%);
    -ms-transform: translateY(-50%);
    -o-transform: translateY(-50%);
}

.text-frame {
    position: absolute;
    left: 50%;
    transform: translate(-50%, -50%);
    -webkit-transform: translate(-50%, -50%);
    -moz-transform: translate(-50%, -50%);
    -ms-transform: translate(-50%, -50%);
    -o-transform: translate(-50%, -50%);
    top: 50%;
}

.text-frame.hero {
    max-height: 160%;
}

.text-frame.package {
    max-height: 130%;
}

#first-image {
    display: list-item;
}

/* End hero section*/


/* About section*/
#about .background-img {
    background-image: url(../img/2.jpg);
}

p.block-intro {
    line-height: 1.4;

}

/* End about section*/


/* Package section*/


.package-header {
    position: relative;
    height: 47px;
}

.package-header h5 span {
    display: block;
    font-size: .8125rem;
    margin-top: .3125rem;
}


.package-body li {
    line-height: 1.7;
    font-family: 'IRANSansWeb(FaNum)', sans-serif;
}


.block-logo img:hover {
    transform: scale(1.05);
    -webkit-transform: scale(1.05);
    -ms-transform: scale(1.05);
    -moz-transform: scale(1.05);
}

.block-logo img {
    opacity: .1;
    margin-bottom: 0;
}

/* End package section*/

/* main section */

.main .background-img {
    background-image: url(../img/3.jpg);
}

/* End main section */


/* Testimonials section*/
.quote {
    direction: ltr !important;
}

.blockquote {
    position: relative;
}

.blockquote p {
    font-weight: 800;
    line-height: 1.4;
    font-size: 2rem;

    position: relative;
}


.blockquote img.quote {
    position: absolute;
    width: 13% !important;;
    right: 0;
    top: 0;
    z-index: -1;
}

.blockquote .quote-info img {
    margin-left: auto;
    margin-right: auto;
    margin-bottom: 1.25rem;
    width: 12% !important;
}

.blockquote .quote-info h6 span {
    display: block;
    font-size: .8125rem;
    margin-top: .3125rem;
}

/* End testimonials section*/


/* Gallery section*/

.gallery-container {
    display: flex;
    flex-wrap: wrap;
    flex-direction: row-reverse;
}

.gallery .block-content .col-lg-4 {
    padding-right: 0;
    padding-left: 0;
}

.gallery .block-content .block-gallery {
    position: relative;
}

.gallery .block-content .block-gallery img {
    margin-bottom: 0;
}

.block-gallery .block-cat a {
    position: absolute;
    background: rgba(17, 17, 17, .4);
    width: 100%;
    height: 100%;
    right: 0;
    top: 0;
}

.block-gallery .block-cat a:hover {
    background: rgba(17, 17, 17, .6);

}

.block-gallery .block-cat h6, .main-slider .block-cat h6 {
    position: absolute;
    right: 2rem;
    bottom: 20px;
    z-index: 4;
    font-size: .90rem;
}


.block-gallery .block-cat i {
    position: absolute;
    left: 2rem;
    bottom: 50px;
    z-index: 4;
    font-size: 1.1rem;
}


.block-gallery .block-cat h6 span, .main-slider .block-cat h6 span {
    display: block;
    font-size: .8125rem;
    margin-top: .3125rem;
    font-weight: 300;
}

.block-content.filter {
    padding: 1.20rem 0;
}

.height-filter {
    height: 37px;
}


.height-filter img.menu-filter-frame {
    -webkit-transform: translateX(-50%);
    -moz-transform: translateX(-50%);
    -ms-transform: translateX(-50%);
    -o-transform: translateX(-50%);
    position: absolute;
    top: 19px;
    max-height: 51%;
    left: 50%;
}

.block-filter {
    z-index: 100;
    width: 100%;
    text-align: center;
}


.block-filter li {
    padding: .75rem 0;
}


.block-filter li, .block-album-nav li {
    margin-left: .98125rem;
    margin-right: .98125rem !important;
    font-size: .6875em;
    letter-spacing: 1px;
    position: relative;
}


.block-filter li a.active:before {
    content: "";
    background: #ffffff;
    width: 100%;
    height: 1px;
    position: absolute;
    top: 20px;

}

.disable:before {
    opacity: .6;
    background-color: #222222;
    content: "";
    display: block;
    height: 100%;
    left: 0;
    position: absolute;
    top: 0;
    width: 100%;
    z-index: 12;
}

.block-info p {
    display: inline-block;
    font-family: 'IRANSansWeb(FaNum)', sans-serif;
}

.block-info .block-name {
    min-width: 347px;
}


.height-album {
    position: absolute;
    left: 50%;
    transform: translateX(-50%);
    -webkit-transform: translateX(-50%);
    -moz-transform: translateX(-50%);
    -ms-transform: translateX(-50%);
    -o-transform: translateX(-50%);
    height: 37px;
    width: 100%;
    top: -10px;
}

.height-album img.menu-album-frame {
    position: absolute;
    max-width: inherit;
    left: 50%;
    transform: translateX(-50%);
    -webkit-transform: translateX(-50%);
    -moz-transform: translateX(-50%);
    -ms-transform: translateX(-50%);
    -o-transform: translateX(-50%);
    max-height: 100%;
    top: -4px;
}


/* End gallery section*/


/* Footer*/


.footer .logo {
    display: block;
    height: 65px;
}

.footer .logo img {
    max-height: 75%;
    margin-left: auto;
    margin-right: auto;
}

.footer a.top {
    color: #ffffff;
    font-size: 1.675rem;
    display: inline-block;
}


/* End footer*/


/*Media queries*/

@media all and (max-width: 990px) {


    .header .left-part,
    .header .right-part {
        display: flex;
    }

    .header .left-part {
        margin-left: 1rem;
        justify-content: flex-end
    }

    .header {
        background-color: #1b1b1b;
        padding: .375rem 0;
    }

    .header .logo {
        margin-top: 0;
    }

    .header .logo img {
        margin-top: .4125rem;
    }

    .mobile-but {
        display: flex;
    }

    .main-nav ul {
        display: none;
        margin-top: 50px
    }

    .main-nav li {
        display: flex;
        margin-left: 1rem;
    }

    .main-nav li a {
        padding: .525rem 0;
    }

    .main-nav li:first-child a {
        padding-top: .625rem;
    }

    .block-logo img {
        width: 35%;
        margin-left: auto;
        margin-right: auto;
    }

}

@media only screen and (min-device-width: 720px) and (max-device-width: 1280px) and (orientation: portrait) {
    input,
    textarea {
        -webkit-appearance: none;
    }

}

@media only screen and (min-device-width: 1024px) and (max-device-width: 1366px) and (orientation: landscape) {

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    h6, .h6 {
        font-size: .9rem;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span, .blockquote .quote-info h6 span {
        font-size: .90rem;
    }

}


@media only screen and (min-device-width: 1024px) and (max-device-width: 1366px)  and (orientation: portrait) {

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    .blockquote p {
        font-size: 1.875rem;
    }

    h6, .h6 {
        font-size: .9rem;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span, .blockquote .quote-info h6 span {
        font-size: .7525rem;
    }

}


@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: landscape) {
    input,
    textarea {
        -webkit-appearance: none;
    }

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    h1, .h1 {
        font-size: 1.675rem;
    }

    h6, .h6 {
        font-size: .8375rem;
    }

    h5, .h5 {
        font-size: 1.15rem;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span, .blockquote .quote-info h6 span {
        font-size: .7125rem;
    }

    .text-frame.hero {
        max-height: 140%;
        top: 40%
    }

    .text-frame.package {
        max-height: 120%;
    }

    .block-gallery .block-cat i {
        left: 1rem;
    }

    .blockquote p {
        font-size: 1.875rem;
    }

    .blockquote img.quote {
        width: 15% !important;
    }

}


@media only screen and (min-width: 768px) and (max-width: 990px) {
    input,
    textarea {
        -webkit-appearance: none;
    }

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    h1, .h1 {
        font-size: 1.675rem;
    }

    h6, .h6 {
        font-size: .9375rem;
    }

    h5, .h5 {
        font-size: 1.15rem;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span {
        font-size: .7125rem;
    }

    .text-frame.hero {
        max-height: 140%;
        top: 40%
    }

    .text-frame.package {
        max-height: 120%;
    }

    .block-filter li {
        margin-left: .48125rem !important;
        margin-right: .48125rem !important;
    }

    .block-logo img {
        width: 25%;
        margin-left: auto;
        margin-right: auto;
    }

    .block-package {
        margin-bottom: 4rem;
    }

    .blockquote p {
        font-size: 1.875rem;
    }

    .blockquote img.quote {
        width: 15% !important;
    }

    .row .col-12.col-lg-4:last-child .block-package {
        margin-bottom: 0;
    }

    section.album .col-12.col-lg-5.offset-lg-1 {
        margin-top: 1rem;
    }

    .height-filter img.menu-filter-frame {
        max-height: 45%;
        top: 22px;
    }

    .main-nav li {
        font-size: .6875rem;
    }

    .col-md-5 {
        -webkit-box-flex: 0;
        -ms-flex: 0 0 80.666667%;
        flex: 0 0 80.666667%;
        max-width: 80.666667%;
    }
}


@media only screen and (min-width: 480px) and (max-width: 767px) {
    input,
    textarea {
        -webkit-appearance: none;
    }

    body {
        font-size: .875rem;
    }

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    h1, .h1 {
        font-size: 1.275rem;
    }

    h6, .h6 {
        font-size: .7675rem;
    }

    .h6 {
        letter-spacing: 3px
    }

    h5, .h5 {
        font-size: 1.05rem;
    }

    .lead {
        font-size: .9375rem;
    }

    .text-small {
        font-size: .75rem;
    }

    .btn {
        font-size: .7125rem;
        padding: 1rem 1rem;
    }

    .block-social li a {
        line-height: 2.2;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span, .blockquote .quote-info h6 span {
        font-size: .6125rem;
    }

    .block-gallery .block-cat h6, .main-slider .block-cat h6 {
        left: 1rem;
    }

    .block-gallery .block-cat i {
        left: 1rem;
        bottom: 42px;
    }

    .text-frame.hero {
        max-height: 105%;
        top: 35%;
    }

    .text-frame.package {
        max-height: 110%;
    }

    .height-filter img.menu-filter-frame {
        max-height: 49%;
    }

    .divider {
        padding-top: 10rem;
        padding-bottom: 10rem;
    }

    .block-package {
        margin-bottom: 4rem;
    }

    .row .col-12.col-lg-4:last-child .block-package {
        margin-bottom: 0;
    }

    .blockquote p {
        font-size: 1.375rem;
    }

    .blockquote img.quote {
        width: 15% !important;
    }

    .block-logo img {
        width: 35%;
        margin-left: auto;
        margin-right: auto;
    }

    section.album .col-12.col-lg-5.offset-lg-1 {
        margin-top: 1rem;
    }


}

@media only screen and (max-width: 479px) {
    input,
    textarea {
        -webkit-appearance: none;
    }


    body {
        font-size: .875rem;
    }

    section.main, .main {
        padding-top: 5.42857rem;
        padding-bottom: 5.42857rem;
    }

    h1, .h1 {
        font-size: 1.275rem;
    }

    h6, .h6 {
        font-size: .7675rem;
    }

    .h6 {
        letter-spacing: 3px
    }

    h5, .h5 {
        font-size: 1.05rem;
    }

    .lead {
        font-size: .9375rem;
    }

    .text-small {
        font-size: .75rem;
    }

    .btn {
        font-size: .7125rem;
        padding: 1rem 1rem;
    }

    .block-social li a {
        line-height: 2.2;
    }

    .block-gallery .block-cat h6 span, .main-slider .block-cat h6 span, .blockquote .quote-info h6 span {
        font-size: .6125rem;
    }

    .text-frame.hero {
        max-height: 105%;
        top: 35%;
    }

    .text-frame.package {
        max-height: 110%;
    }

    .height-filter {
        height: auto;
    }

    .block-gallery .block-cat h6, .main-slider .block-cat h6 {
        left: 1rem;
    }

    .block-gallery .block-cat i {
        left: 1rem;
        bottom: 42px;
    }

    .blockquote .quote-info img {
        width: 20% !important;
    }

    .flex-direction-nav .flex-prev {
        left: 1rem !important;
    }

    .flex-direction-nav .flex-next {
        right: 1rem !important;
    }

    .block-logo img {
        width: 50%;
        margin-left: auto;
        margin-right: auto;
    }

    .block-package {
        margin-bottom: 2rem;
    }

    .blockquote p {
        font-size: 1.375rem;
    }

    .blockquote img.quote {
        width: 20% !important;
    }

    .row .col-12.col-lg-4:last-child .block-package {
        margin-bottom: 0;
    }

    .height-filter img.menu-filter-frame, .height-album img.menu-album-frame {
        display: none;
    }

    .block-info .block-name {
        min-width: 190px;
    }

    section.album .col-12.col-lg-5.offset-lg-1 {
        margin-top: 1rem;
    }
}

/*End media queries*/
