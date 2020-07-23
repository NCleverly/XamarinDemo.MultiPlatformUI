﻿using System;
using System.Collections.Generic;
/*
    URL - http://fontawesome.io/
*/
namespace Xamarin.Forms.Core
{
    
    public static class FontAwesome
    {
        public static string FontFamily{
            get{
                if (Device.RuntimePlatform.ToUpper().Equals("IOS"))
                    return "FontAwesome";
                else
                    return "fontawesome.ttf#FontAwesome";
            }
        }

        public static Dictionary<string, char> Icons { get; set; } = new Dictionary<string, char>();

        static FontAwesome()
        {
            Icons.Add("fa-500px", '\uf26e');
            Icons.Add("fa-address-book", '\uf2b9');
            Icons.Add("fa-address-book-o", '\uf2ba');
            Icons.Add("fa-address-card", '\uf2bb');
            Icons.Add("fa-address-card-o", '\uf2bc');
            Icons.Add("fa-adjust", '\uf042');
            Icons.Add("fa-adn", '\uf170');
            Icons.Add("fa-align-center", '\uf037');
            Icons.Add("fa-align-justify", '\uf039');
            Icons.Add("fa-align-left", '\uf036');
            Icons.Add("fa-align-right", '\uf038');
            Icons.Add("fa-amazon", '\uf270');
            Icons.Add("fa-ambulance", '\uf0f9');
            Icons.Add("fa-american-sign-language-interpreting", '\uf2a3');
            Icons.Add("fa-anchor", '\uf13d');
            Icons.Add("fa-android", '\uf17b');
            Icons.Add("fa-angellist", '\uf209');
            Icons.Add("fa-angle-double-down", '\uf103');
            Icons.Add("fa-angle-double-left", '\uf100');
            Icons.Add("fa-angle-double-right", '\uf101');
            Icons.Add("fa-angle-double-up", '\uf102');
            Icons.Add("fa-angle-down", '\uf107');
            Icons.Add("fa-angle-left", '\uf104');
            Icons.Add("fa-angle-right", '\uf105');
            Icons.Add("fa-angle-up", '\uf106');
            Icons.Add("fa-apple", '\uf179');
            Icons.Add("fa-archive", '\uf187');
            Icons.Add("fa-area-chart", '\uf1fe');
            Icons.Add("fa-arrow-circle-down", '\uf0ab');
            Icons.Add("fa-arrow-circle-left", '\uf0a8');
            Icons.Add("fa-arrow-circle-o-down", '\uf01a');
            Icons.Add("fa-arrow-circle-o-left", '\uf190');
            Icons.Add("fa-arrow-circle-o-right", '\uf18e');
            Icons.Add("fa-arrow-circle-o-up", '\uf01b');
            Icons.Add("fa-arrow-circle-right", '\uf0a9');
            Icons.Add("fa-arrow-circle-up", '\uf0aa');
            Icons.Add("fa-arrow-down", '\uf063');
            Icons.Add("fa-arrow-left", '\uf060');
            Icons.Add("fa-arrow-right", '\uf061');
            Icons.Add("fa-arrow-up", '\uf062');
            Icons.Add("fa-arrows", '\uf047');
            Icons.Add("fa-arrows-alt", '\uf0b2');
            Icons.Add("fa-arrows-h", '\uf07e');
            Icons.Add("fa-arrows-v", '\uf07d');
            Icons.Add("fa-asl-interpreting", '\uf2a3');
            Icons.Add("fa-assistive-listening-systems", '\uf2a2');
            Icons.Add("fa-asterisk", '\uf069');
            Icons.Add("fa-at", '\uf1fa');
            Icons.Add("fa-audio-description", '\uf29e');
            Icons.Add("fa-automobile", '\uf1b9');
            Icons.Add("fa-backward", '\uf04a');
            Icons.Add("fa-balance-scale", '\uf24e');
            Icons.Add("fa-ban", '\uf05e');
            Icons.Add("fa-bandcamp", '\uf2d5');
            Icons.Add("fa-bank", '\uf19c');
            Icons.Add("fa-bar-chart", '\uf080');
            Icons.Add("fa-bar-chart-o", '\uf080');
            Icons.Add("fa-barcode", '\uf02a');
            Icons.Add("fa-bars", '\uf0c9');
            Icons.Add("fa-bath", '\uf2cd');
            Icons.Add("fa-bathtub", '\uf2cd');
            Icons.Add("fa-battery", '\uf240');
            Icons.Add("fa-battery-0", '\uf244');
            Icons.Add("fa-battery-1", '\uf243');
            Icons.Add("fa-battery-2", '\uf242');
            Icons.Add("fa-battery-3", '\uf241');
            Icons.Add("fa-battery-4", '\uf240');
            Icons.Add("fa-battery-empty", '\uf244');
            Icons.Add("fa-battery-full", '\uf240');
            Icons.Add("fa-battery-half", '\uf242');
            Icons.Add("fa-battery-quarter", '\uf243');
            Icons.Add("fa-battery-three-quarters", '\uf241');
            Icons.Add("fa-bed", '\uf236');
            Icons.Add("fa-beer", '\uf0fc');
            Icons.Add("fa-behance", '\uf1b4');
            Icons.Add("fa-behance-square", '\uf1b5');
            Icons.Add("fa-bell", '\uf0f3');
            Icons.Add("fa-bell-o", '\uf0a2');
            Icons.Add("fa-bell-slash", '\uf1f6');
            Icons.Add("fa-bell-slash-o", '\uf1f7');
            Icons.Add("fa-bicycle", '\uf206');
            Icons.Add("fa-binoculars", '\uf1e5');
            Icons.Add("fa-birthday-cake", '\uf1fd');
            Icons.Add("fa-bitbucket", '\uf171');
            Icons.Add("fa-bitbucket-square", '\uf172');
            Icons.Add("fa-bitcoin", '\uf15a');
            Icons.Add("fa-black-tie", '\uf27e');
            Icons.Add("fa-blind", '\uf29d');
            Icons.Add("fa-bluetooth", '\uf293');
            Icons.Add("fa-bluetooth-b", '\uf294');
            Icons.Add("fa-bold", '\uf032');
            Icons.Add("fa-bolt", '\uf0e7');
            Icons.Add("fa-bomb", '\uf1e2');
            Icons.Add("fa-book", '\uf02d');
            Icons.Add("fa-bookmark", '\uf02e');
            Icons.Add("fa-bookmark-o", '\uf097');
            Icons.Add("fa-braille", '\uf2a1');
            Icons.Add("fa-briefcase", '\uf0b1');
            Icons.Add("fa-btc", '\uf15a');
            Icons.Add("fa-bug", '\uf188');
            Icons.Add("fa-building", '\uf1ad');
            Icons.Add("fa-building-o", '\uf0f7');
            Icons.Add("fa-bullhorn", '\uf0a1');
            Icons.Add("fa-bullseye", '\uf140');
            Icons.Add("fa-bus", '\uf207');
            Icons.Add("fa-buysellads", '\uf20d');
            Icons.Add("fa-cab", '\uf1ba');
            Icons.Add("fa-calculator", '\uf1ec');
            Icons.Add("fa-calendar", '\uf073');
            Icons.Add("fa-calendar-check-o", '\uf274');
            Icons.Add("fa-calendar-minus-o", '\uf272');
            Icons.Add("fa-calendar-o", '\uf133');
            Icons.Add("fa-calendar-plus-o", '\uf271');
            Icons.Add("fa-calendar-times-o", '\uf273');
            Icons.Add("fa-camera", '\uf030');
            Icons.Add("fa-camera-retro", '\uf083');
            Icons.Add("fa-car", '\uf1b9');
            Icons.Add("fa-caret-down", '\uf0d7');
            Icons.Add("fa-caret-left", '\uf0d9');
            Icons.Add("fa-caret-right", '\uf0da');
            Icons.Add("fa-caret-square-o-down", '\uf150');
            Icons.Add("fa-caret-square-o-left", '\uf191');
            Icons.Add("fa-caret-square-o-right", '\uf152');
            Icons.Add("fa-caret-square-o-up", '\uf151');
            Icons.Add("fa-caret-up", '\uf0d8');
            Icons.Add("fa-cart-arrow-down", '\uf218');
            Icons.Add("fa-cart-plus", '\uf217');
            Icons.Add("fa-cc", '\uf20a');
            Icons.Add("fa-cc-amex", '\uf1f3');
            Icons.Add("fa-cc-diners-club", '\uf24c');
            Icons.Add("fa-cc-discover", '\uf1f2');
            Icons.Add("fa-cc-jcb", '\uf24b');
            Icons.Add("fa-cc-mastercard", '\uf1f1');
            Icons.Add("fa-cc-paypal", '\uf1f4');
            Icons.Add("fa-cc-stripe", '\uf1f5');
            Icons.Add("fa-cc-visa", '\uf1f0');
            Icons.Add("fa-certificate", '\uf0a3');
            Icons.Add("fa-chain", '\uf0c1');
            Icons.Add("fa-chain-broken", '\uf127');
            Icons.Add("fa-check", '\uf00c');
            Icons.Add("fa-check-circle", '\uf058');
            Icons.Add("fa-check-circle-o", '\uf05d');
            Icons.Add("fa-check-square", '\uf14a');
            Icons.Add("fa-check-square-o", '\uf046');
            Icons.Add("fa-chevron-circle-down", '\uf13a');
            Icons.Add("fa-chevron-circle-left", '\uf137');
            Icons.Add("fa-chevron-circle-right", '\uf138');
            Icons.Add("fa-chevron-circle-up", '\uf139');
            Icons.Add("fa-chevron-down", '\uf078');
            Icons.Add("fa-chevron-left", '\uf053');
            Icons.Add("fa-chevron-right", '\uf054');
            Icons.Add("fa-chevron-up", '\uf077');
            Icons.Add("fa-child", '\uf1ae');
            Icons.Add("fa-chrome", '\uf268');
            Icons.Add("fa-circle", '\uf111');
            Icons.Add("fa-circle-o", '\uf10c');
            Icons.Add("fa-circle-o-notch", '\uf1ce');
            Icons.Add("fa-circle-thin", '\uf1db');
            Icons.Add("fa-clipboard", '\uf0ea');
            Icons.Add("fa-clock-o", '\uf017');
            Icons.Add("fa-clone", '\uf24d');
            Icons.Add("fa-close", '\uf00d');
            Icons.Add("fa-cloud", '\uf0c2');
            Icons.Add("fa-cloud-download", '\uf0ed');
            Icons.Add("fa-cloud-upload", '\uf0ee');
            Icons.Add("fa-cny", '\uf157');
            Icons.Add("fa-code", '\uf121');
            Icons.Add("fa-code-fork", '\uf126');
            Icons.Add("fa-codepen", '\uf1cb');
            Icons.Add("fa-codiepie", '\uf284');
            Icons.Add("fa-coffee", '\uf0f4');
            Icons.Add("fa-cog", '\uf013');
            Icons.Add("fa-cogs", '\uf085');
            Icons.Add("fa-columns", '\uf0db');
            Icons.Add("fa-comment", '\uf075');
            Icons.Add("fa-comment-o", '\uf0e5');
            Icons.Add("fa-commenting", '\uf27a');
            Icons.Add("fa-commenting-o", '\uf27b');
            Icons.Add("fa-comments", '\uf086');
            Icons.Add("fa-comments-o", '\uf0e6');
            Icons.Add("fa-compass", '\uf14e');
            Icons.Add("fa-compress", '\uf066');
            Icons.Add("fa-connectdevelop", '\uf20e');
            Icons.Add("fa-contao", '\uf26d');
            Icons.Add("fa-copy", '\uf0c5');
            Icons.Add("fa-copyright", '\uf1f9');
            Icons.Add("fa-creative-commons", '\uf25e');
            Icons.Add("fa-credit-card", '\uf09d');
            Icons.Add("fa-credit-card-alt", '\uf283');
            Icons.Add("fa-crop", '\uf125');
            Icons.Add("fa-crosshairs", '\uf05b');
            Icons.Add("fa-css3", '\uf13c');
            Icons.Add("fa-cube", '\uf1b2');
            Icons.Add("fa-cubes", '\uf1b3');
            Icons.Add("fa-cut", '\uf0c4');
            Icons.Add("fa-cutlery", '\uf0f5');
            Icons.Add("fa-dashboard", '\uf0e4');
            Icons.Add("fa-dashcube", '\uf210');
            Icons.Add("fa-database", '\uf1c0');
            Icons.Add("fa-deaf", '\uf2a4');
            Icons.Add("fa-deafness", '\uf2a4');
            Icons.Add("fa-dedent", '\uf03b');
            Icons.Add("fa-delicious", '\uf1a5');
            Icons.Add("fa-desktop", '\uf108');
            Icons.Add("fa-deviantart", '\uf1bd');
            Icons.Add("fa-diamond", '\uf219');
            Icons.Add("fa-digg", '\uf1a6');
            Icons.Add("fa-dollar", '\uf155');
            Icons.Add("fa-dot-circle-o", '\uf192');
            Icons.Add("fa-download", '\uf019');
            Icons.Add("fa-dribbble", '\uf17d');
            Icons.Add("fa-drivers-license", '\uf2c2');
            Icons.Add("fa-drivers-license-o", '\uf2c3');
            Icons.Add("fa-dropbox", '\uf16b');
            Icons.Add("fa-drupal", '\uf1a9');
            Icons.Add("fa-edge", '\uf282');
            Icons.Add("fa-edit", '\uf044');
            Icons.Add("fa-eercast", '\uf2da');
            Icons.Add("fa-eject", '\uf052');
            Icons.Add("fa-ellipsis-h", '\uf141');
            Icons.Add("fa-ellipsis-v", '\uf142');
            Icons.Add("fa-empire", '\uf1d1');
            Icons.Add("fa-envelope", '\uf0e0');
            Icons.Add("fa-envelope-o", '\uf003');
            Icons.Add("fa-envelope-open", '\uf2b6');
            Icons.Add("fa-envelope-open-o", '\uf2b7');
            Icons.Add("fa-envelope-square", '\uf199');
            Icons.Add("fa-envira", '\uf299');
            Icons.Add("fa-eraser", '\uf12d');
            Icons.Add("fa-etsy", '\uf2d7');
            Icons.Add("fa-eur", '\uf153');
            Icons.Add("fa-euro", '\uf153');
            Icons.Add("fa-exchange", '\uf0ec');
            Icons.Add("fa-exclamation", '\uf12a');
            Icons.Add("fa-exclamation-circle", '\uf06a');
            Icons.Add("fa-exclamation-triangle", '\uf071');
            Icons.Add("fa-expand", '\uf065');
            Icons.Add("fa-expeditedssl", '\uf23e');
            Icons.Add("fa-external-link", '\uf08e');
            Icons.Add("fa-external-link-square", '\uf14c');
            Icons.Add("fa-eye", '\uf06e');
            Icons.Add("fa-eye-slash", '\uf070');
            Icons.Add("fa-eyedropper", '\uf1fb');
            Icons.Add("fa-fa", '\uf2b4');
            Icons.Add("fa-facebook", '\uf09a');
            Icons.Add("fa-facebook-f", '\uf09a');
            Icons.Add("fa-facebook-official", '\uf230');
            Icons.Add("fa-facebook-square", '\uf082');
            Icons.Add("fa-fast-backward", '\uf049');
            Icons.Add("fa-fast-forward", '\uf050');
            Icons.Add("fa-fax", '\uf1ac');
            Icons.Add("fa-feed", '\uf09e');
            Icons.Add("fa-female", '\uf182');
            Icons.Add("fa-fighter-jet", '\uf0fb');
            Icons.Add("fa-file", '\uf15b');
            Icons.Add("fa-file-archive-o", '\uf1c6');
            Icons.Add("fa-file-audio-o", '\uf1c7');
            Icons.Add("fa-file-code-o", '\uf1c9');
            Icons.Add("fa-file-excel-o", '\uf1c3');
            Icons.Add("fa-file-image-o", '\uf1c5');
            Icons.Add("fa-file-movie-o", '\uf1c8');
            Icons.Add("fa-file-o", '\uf016');
            Icons.Add("fa-file-pdf-o", '\uf1c1');
            Icons.Add("fa-file-photo-o", '\uf1c5');
            Icons.Add("fa-file-picture-o", '\uf1c5');
            Icons.Add("fa-file-powerpoint-o", '\uf1c4');
            Icons.Add("fa-file-sound-o", '\uf1c7');
            Icons.Add("fa-file-text", '\uf15c');
            Icons.Add("fa-file-text-o", '\uf0f6');
            Icons.Add("fa-file-video-o", '\uf1c8');
            Icons.Add("fa-file-word-o", '\uf1c2');
            Icons.Add("fa-file-zip-o", '\uf1c6');
            Icons.Add("fa-files-o", '\uf0c5');
            Icons.Add("fa-film", '\uf008');
            Icons.Add("fa-filter", '\uf0b0');
            Icons.Add("fa-fire", '\uf06d');
            Icons.Add("fa-fire-extinguisher", '\uf134');
            Icons.Add("fa-firefox", '\uf269');
            Icons.Add("fa-first-order", '\uf2b0');
            Icons.Add("fa-flag", '\uf024');
            Icons.Add("fa-flag-checkered", '\uf11e');
            Icons.Add("fa-flag-o", '\uf11d');
            Icons.Add("fa-flash", '\uf0e7');
            Icons.Add("fa-flask", '\uf0c3');
            Icons.Add("fa-flickr", '\uf16e');
            Icons.Add("fa-floppy-o", '\uf0c7');
            Icons.Add("fa-folder", '\uf07b');
            Icons.Add("fa-folder-o", '\uf114');
            Icons.Add("fa-folder-open", '\uf07c');
            Icons.Add("fa-folder-open-o", '\uf115');
            Icons.Add("fa-font", '\uf031');
            Icons.Add("fa-font-awesome", '\uf2b4');
            Icons.Add("fa-fonticons", '\uf280');
            Icons.Add("fa-fort-awesome", '\uf286');
            Icons.Add("fa-forumbee", '\uf211');
            Icons.Add("fa-forward", '\uf04e');
            Icons.Add("fa-foursquare", '\uf180');
            Icons.Add("fa-free-code-camp", '\uf2c5');
            Icons.Add("fa-frown-o", '\uf119');
            Icons.Add("fa-futbol-o", '\uf1e3');
            Icons.Add("fa-gamepad", '\uf11b');
            Icons.Add("fa-gavel", '\uf0e3');
            Icons.Add("fa-gbp", '\uf154');
            Icons.Add("fa-ge", '\uf1d1');
            Icons.Add("fa-gear", '\uf013');
            Icons.Add("fa-gears", '\uf085');
            Icons.Add("fa-genderless", '\uf22d');
            Icons.Add("fa-get-pocket", '\uf265');
            Icons.Add("fa-gg", '\uf260');
            Icons.Add("fa-gg-circle", '\uf261');
            Icons.Add("fa-gift", '\uf06b');
            Icons.Add("fa-git", '\uf1d3');
            Icons.Add("fa-git-square", '\uf1d2');
            Icons.Add("fa-github", '\uf09b');
            Icons.Add("fa-github-alt", '\uf113');
            Icons.Add("fa-github-square", '\uf092');
            Icons.Add("fa-gitlab", '\uf296');
            Icons.Add("fa-gittip", '\uf184');
            Icons.Add("fa-glass", '\uf000');
            Icons.Add("fa-glide", '\uf2a5');
            Icons.Add("fa-glide-g", '\uf2a6');
            Icons.Add("fa-globe", '\uf0ac');
            Icons.Add("fa-google", '\uf1a0');
            Icons.Add("fa-google-plus", '\uf0d5');
            Icons.Add("fa-google-plus-circle", '\uf2b3');
            Icons.Add("fa-google-plus-official", '\uf2b3');
            Icons.Add("fa-google-plus-square", '\uf0d4');
            Icons.Add("fa-google-wallet", '\uf1ee');
            Icons.Add("fa-graduation-cap", '\uf19d');
            Icons.Add("fa-gratipay", '\uf184');
            Icons.Add("fa-grav", '\uf2d6');
            Icons.Add("fa-group", '\uf0c0');
            Icons.Add("fa-h-square", '\uf0fd');
            Icons.Add("fa-hacker-news", '\uf1d4');
            Icons.Add("fa-hand-grab-o", '\uf255');
            Icons.Add("fa-hand-lizard-o", '\uf258');
            Icons.Add("fa-hand-o-down", '\uf0a7');
            Icons.Add("fa-hand-o-left", '\uf0a5');
            Icons.Add("fa-hand-o-right", '\uf0a4');
            Icons.Add("fa-hand-o-up", '\uf0a6');
            Icons.Add("fa-hand-paper-o", '\uf256');
            Icons.Add("fa-hand-peace-o", '\uf25b');
            Icons.Add("fa-hand-pointer-o", '\uf25a');
            Icons.Add("fa-hand-rock-o", '\uf255');
            Icons.Add("fa-hand-scissors-o", '\uf257');
            Icons.Add("fa-hand-spock-o", '\uf259');
            Icons.Add("fa-hand-stop-o", '\uf256');
            Icons.Add("fa-handshake-o", '\uf2b5');
            Icons.Add("fa-hard-of-hearing", '\uf2a4');
            Icons.Add("fa-hashtag", '\uf292');
            Icons.Add("fa-hdd-o", '\uf0a0');
            Icons.Add("fa-header", '\uf1dc');
            Icons.Add("fa-headphones", '\uf025');
            Icons.Add("fa-heart", '\uf004');
            Icons.Add("fa-heart-o", '\uf08a');
            Icons.Add("fa-heartbeat", '\uf21e');
            Icons.Add("fa-history", '\uf1da');
            Icons.Add("fa-home", '\uf015');
            Icons.Add("fa-hospital-o", '\uf0f8');
            Icons.Add("fa-hotel", '\uf236');
            Icons.Add("fa-hourglass", '\uf254');
            Icons.Add("fa-hourglass-1", '\uf251');
            Icons.Add("fa-hourglass-2", '\uf252');
            Icons.Add("fa-hourglass-3", '\uf253');
            Icons.Add("fa-hourglass-end", '\uf253');
            Icons.Add("fa-hourglass-half", '\uf252');
            Icons.Add("fa-hourglass-o", '\uf250');
            Icons.Add("fa-hourglass-start", '\uf251');
            Icons.Add("fa-houzz", '\uf27c');
            Icons.Add("fa-html5", '\uf13b');
            Icons.Add("fa-i-cursor", '\uf246');
            Icons.Add("fa-id-badge", '\uf2c1');
            Icons.Add("fa-id-card", '\uf2c2');
            Icons.Add("fa-id-card-o", '\uf2c3');
            Icons.Add("fa-ils", '\uf20b');
            Icons.Add("fa-image", '\uf03e');
            Icons.Add("fa-imdb", '\uf2d8');
            Icons.Add("fa-inbox", '\uf01c');
            Icons.Add("fa-indent", '\uf03c');
            Icons.Add("fa-industry", '\uf275');
            Icons.Add("fa-info", '\uf129');
            Icons.Add("fa-info-circle", '\uf05a');
            Icons.Add("fa-inr", '\uf156');
            Icons.Add("fa-instagram", '\uf16d');
            Icons.Add("fa-institution", '\uf19c');
            Icons.Add("fa-internet-explorer", '\uf26b');
            Icons.Add("fa-intersex", '\uf224');
            Icons.Add("fa-ioxhost", '\uf208');
            Icons.Add("fa-italic", '\uf033');
            Icons.Add("fa-joomla", '\uf1aa');
            Icons.Add("fa-jpy", '\uf157');
            Icons.Add("fa-jsfiddle", '\uf1cc');
            Icons.Add("fa-key", '\uf084');
            Icons.Add("fa-keyboard-o", '\uf11c');
            Icons.Add("fa-krw", '\uf159');
            Icons.Add("fa-language", '\uf1ab');
            Icons.Add("fa-laptop", '\uf109');
            Icons.Add("fa-lastfm", '\uf202');
            Icons.Add("fa-lastfm-square", '\uf203');
            Icons.Add("fa-leaf", '\uf06c');
            Icons.Add("fa-leanpub", '\uf212');
            Icons.Add("fa-legal", '\uf0e3');
            Icons.Add("fa-lemon-o", '\uf094');
            Icons.Add("fa-level-down", '\uf149');
            Icons.Add("fa-level-up", '\uf148');
            Icons.Add("fa-life-bouy", '\uf1cd');
            Icons.Add("fa-life-buoy", '\uf1cd');
            Icons.Add("fa-life-ring", '\uf1cd');
            Icons.Add("fa-life-saver", '\uf1cd');
            Icons.Add("fa-lightbulb-o", '\uf0eb');
            Icons.Add("fa-line-chart", '\uf201');
            Icons.Add("fa-link", '\uf0c1');
            Icons.Add("fa-linkedin", '\uf0e1');
            Icons.Add("fa-linkedin-square", '\uf08c');
            Icons.Add("fa-linode", '\uf2b8');
            Icons.Add("fa-linux", '\uf17c');
            Icons.Add("fa-list", '\uf03a');
            Icons.Add("fa-list-alt", '\uf022');
            Icons.Add("fa-list-ol", '\uf0cb');
            Icons.Add("fa-list-ul", '\uf0ca');
            Icons.Add("fa-location-arrow", '\uf124');
            Icons.Add("fa-lock", '\uf023');
            Icons.Add("fa-long-arrow-down", '\uf175');
            Icons.Add("fa-long-arrow-left", '\uf177');
            Icons.Add("fa-long-arrow-right", '\uf178');
            Icons.Add("fa-long-arrow-up", '\uf176');
            Icons.Add("fa-low-vision", '\uf2a8');
            Icons.Add("fa-magic", '\uf0d0');
            Icons.Add("fa-magnet", '\uf076');
            Icons.Add("fa-mail-forward", '\uf064');
            Icons.Add("fa-mail-reply", '\uf112');
            Icons.Add("fa-mail-reply-all", '\uf122');
            Icons.Add("fa-male", '\uf183');
            Icons.Add("fa-map", '\uf279');
            Icons.Add("fa-map-marker", '\uf041');
            Icons.Add("fa-map-o", '\uf278');
            Icons.Add("fa-map-pin", '\uf276');
            Icons.Add("fa-map-signs", '\uf277');
            Icons.Add("fa-mars", '\uf222');
            Icons.Add("fa-mars-double", '\uf227');
            Icons.Add("fa-mars-stroke", '\uf229');
            Icons.Add("fa-mars-stroke-h", '\uf22b');
            Icons.Add("fa-mars-stroke-v", '\uf22a');
            Icons.Add("fa-maxcdn", '\uf136');
            Icons.Add("fa-meanpath", '\uf20c');
            Icons.Add("fa-medium", '\uf23a');
            Icons.Add("fa-medkit", '\uf0fa');
            Icons.Add("fa-meetup", '\uf2e0');
            Icons.Add("fa-meh-o", '\uf11a');
            Icons.Add("fa-mercury", '\uf223');
            Icons.Add("fa-microchip", '\uf2db');
            Icons.Add("fa-microphone", '\uf130');
            Icons.Add("fa-microphone-slash", '\uf131');
            Icons.Add("fa-minus", '\uf068');
            Icons.Add("fa-minus-circle", '\uf056');
            Icons.Add("fa-minus-square", '\uf146');
            Icons.Add("fa-minus-square-o", '\uf147');
            Icons.Add("fa-mixcloud", '\uf289');
            Icons.Add("fa-mobile", '\uf10b');
            Icons.Add("fa-mobile-phone", '\uf10b');
            Icons.Add("fa-modx", '\uf285');
            Icons.Add("fa-money", '\uf0d6');
            Icons.Add("fa-moon-o", '\uf186');
            Icons.Add("fa-mortar-board", '\uf19d');
            Icons.Add("fa-motorcycle", '\uf21c');
            Icons.Add("fa-mouse-pointer", '\uf245');
            Icons.Add("fa-music", '\uf001');
            Icons.Add("fa-navicon", '\uf0c9');
            Icons.Add("fa-neuter", '\uf22c');
            Icons.Add("fa-newspaper-o", '\uf1ea');
            Icons.Add("fa-object-group", '\uf247');
            Icons.Add("fa-object-ungroup", '\uf248');
            Icons.Add("fa-odnoklassniki", '\uf263');
            Icons.Add("fa-odnoklassniki-square", '\uf264');
            Icons.Add("fa-opencart", '\uf23d');
            Icons.Add("fa-openid", '\uf19b');
            Icons.Add("fa-opera", '\uf26a');
            Icons.Add("fa-optin-monster", '\uf23c');
            Icons.Add("fa-outdent", '\uf03b');
            Icons.Add("fa-pagelines", '\uf18c');
            Icons.Add("fa-paint-brush", '\uf1fc');
            Icons.Add("fa-paper-plane", '\uf1d8');
            Icons.Add("fa-paper-plane-o", '\uf1d9');
            Icons.Add("fa-paperclip", '\uf0c6');
            Icons.Add("fa-paragraph", '\uf1dd');
            Icons.Add("fa-paste", '\uf0ea');
            Icons.Add("fa-pause", '\uf04c');
            Icons.Add("fa-pause-circle", '\uf28b');
            Icons.Add("fa-pause-circle-o", '\uf28c');
            Icons.Add("fa-paw", '\uf1b0');
            Icons.Add("fa-paypal", '\uf1ed');
            Icons.Add("fa-pencil", '\uf040');
            Icons.Add("fa-pencil-square", '\uf14b');
            Icons.Add("fa-pencil-square-o", '\uf044');
            Icons.Add("fa-percent", '\uf295');
            Icons.Add("fa-phone", '\uf095');
            Icons.Add("fa-phone-square", '\uf098');
            Icons.Add("fa-photo", '\uf03e');
            Icons.Add("fa-picture-o", '\uf03e');
            Icons.Add("fa-pie-chart", '\uf200');
            Icons.Add("fa-pied-piper", '\uf2ae');
            Icons.Add("fa-pied-piper-alt", '\uf1a8');
            Icons.Add("fa-pied-piper-pp", '\uf1a7');
            Icons.Add("fa-pinterest", '\uf0d2');
            Icons.Add("fa-pinterest-p", '\uf231');
            Icons.Add("fa-pinterest-square", '\uf0d3');
            Icons.Add("fa-plane", '\uf072');
            Icons.Add("fa-play", '\uf04b');
            Icons.Add("fa-play-circle", '\uf144');
            Icons.Add("fa-play-circle-o", '\uf01d');
            Icons.Add("fa-plug", '\uf1e6');
            Icons.Add("fa-plus", '\uf067');
            Icons.Add("fa-plus-circle", '\uf055');
            Icons.Add("fa-plus-square", '\uf0fe');
            Icons.Add("fa-plus-square-o", '\uf196');
            Icons.Add("fa-podcast", '\uf2ce');
            Icons.Add("fa-power-off", '\uf011');
            Icons.Add("fa-print", '\uf02f');
            Icons.Add("fa-product-hunt", '\uf288');
            Icons.Add("fa-puzzle-piece", '\uf12e');
            Icons.Add("fa-qq", '\uf1d6');
            Icons.Add("fa-qrcode", '\uf029');
            Icons.Add("fa-question", '\uf128');
            Icons.Add("fa-question-circle", '\uf059');
            Icons.Add("fa-question-circle-o", '\uf29c');
            Icons.Add("fa-quora", '\uf2c4');
            Icons.Add("fa-quote-left", '\uf10d');
            Icons.Add("fa-quote-right", '\uf10e');
            Icons.Add("fa-ra", '\uf1d0');
            Icons.Add("fa-random", '\uf074');
            Icons.Add("fa-ravelry", '\uf2d9');
            Icons.Add("fa-rebel", '\uf1d0');
            Icons.Add("fa-recycle", '\uf1b8');
            Icons.Add("fa-reddit", '\uf1a1');
            Icons.Add("fa-reddit-alien", '\uf281');
            Icons.Add("fa-reddit-square", '\uf1a2');
            Icons.Add("fa-refresh", '\uf021');
            Icons.Add("fa-registered", '\uf25d');
            Icons.Add("fa-remove", '\uf00d');
            Icons.Add("fa-renren", '\uf18b');
            Icons.Add("fa-reorder", '\uf0c9');
            Icons.Add("fa-repeat", '\uf01e');
            Icons.Add("fa-reply", '\uf112');
            Icons.Add("fa-reply-all", '\uf122');
            Icons.Add("fa-resistance", '\uf1d0');
            Icons.Add("fa-retweet", '\uf079');
            Icons.Add("fa-rmb", '\uf157');
            Icons.Add("fa-road", '\uf018');
            Icons.Add("fa-rocket", '\uf135');
            Icons.Add("fa-rotate-left", '\uf0e2');
            Icons.Add("fa-rotate-right", '\uf01e');
            Icons.Add("fa-rouble", '\uf158');
            Icons.Add("fa-rss", '\uf09e');
            Icons.Add("fa-rss-square", '\uf143');
            Icons.Add("fa-rub", '\uf158');
            Icons.Add("fa-ruble", '\uf158');
            Icons.Add("fa-rupee", '\uf156');
            Icons.Add("fa-s15", '\uf2cd');
            Icons.Add("fa-safari", '\uf267');
            Icons.Add("fa-save", '\uf0c7');
            Icons.Add("fa-scissors", '\uf0c4');
            Icons.Add("fa-scribd", '\uf28a');
            Icons.Add("fa-search", '\uf002');
            Icons.Add("fa-search-minus", '\uf010');
            Icons.Add("fa-search-plus", '\uf00e');
            Icons.Add("fa-sellsy", '\uf213');
            Icons.Add("fa-send", '\uf1d8');
            Icons.Add("fa-send-o", '\uf1d9');
            Icons.Add("fa-server", '\uf233');
            Icons.Add("fa-share", '\uf064');
            Icons.Add("fa-share-alt", '\uf1e0');
            Icons.Add("fa-share-alt-square", '\uf1e1');
            Icons.Add("fa-share-square", '\uf14d');
            Icons.Add("fa-share-square-o", '\uf045');
            Icons.Add("fa-shekel", '\uf20b');
            Icons.Add("fa-sheqel", '\uf20b');
            Icons.Add("fa-shield", '\uf132');
            Icons.Add("fa-ship", '\uf21a');
            Icons.Add("fa-shirtsinbulk", '\uf214');
            Icons.Add("fa-shopping-bag", '\uf290');
            Icons.Add("fa-shopping-basket", '\uf291');
            Icons.Add("fa-shopping-cart", '\uf07a');
            Icons.Add("fa-shower", '\uf2cc');
            Icons.Add("fa-sign-in", '\uf090');
            Icons.Add("fa-sign-language", '\uf2a7');
            Icons.Add("fa-sign-out", '\uf08b');
            Icons.Add("fa-signal", '\uf012');
            Icons.Add("fa-signing", '\uf2a7');
            Icons.Add("fa-simplybuilt", '\uf215');
            Icons.Add("fa-sitemap", '\uf0e8');
            Icons.Add("fa-skyatlas", '\uf216');
            Icons.Add("fa-skype", '\uf17e');
            Icons.Add("fa-slack", '\uf198');
            Icons.Add("fa-sliders", '\uf1de');
            Icons.Add("fa-slideshare", '\uf1e7');
            Icons.Add("fa-smile-o", '\uf118');
            Icons.Add("fa-snapchat", '\uf2ab');
            Icons.Add("fa-snapchat-ghost", '\uf2ac');
            Icons.Add("fa-snapchat-square", '\uf2ad');
            Icons.Add("fa-snowflake-o", '\uf2dc');
            Icons.Add("fa-soccer-ball-o", '\uf1e3');
            Icons.Add("fa-sort", '\uf0dc');
            Icons.Add("fa-sort-alpha-asc", '\uf15d');
            Icons.Add("fa-sort-alpha-desc", '\uf15e');
            Icons.Add("fa-sort-amount-asc", '\uf160');
            Icons.Add("fa-sort-amount-desc", '\uf161');
            Icons.Add("fa-sort-asc", '\uf0de');
            Icons.Add("fa-sort-desc", '\uf0dd');
            Icons.Add("fa-sort-down", '\uf0dd');
            Icons.Add("fa-sort-numeric-asc", '\uf162');
            Icons.Add("fa-sort-numeric-desc", '\uf163');
            Icons.Add("fa-sort-up", '\uf0de');
            Icons.Add("fa-soundcloud", '\uf1be');
            Icons.Add("fa-space-shuttle", '\uf197');
            Icons.Add("fa-spinner", '\uf110');
            Icons.Add("fa-spoon", '\uf1b1');
            Icons.Add("fa-spotify", '\uf1bc');
            Icons.Add("fa-square", '\uf0c8');
            Icons.Add("fa-square-o", '\uf096');
            Icons.Add("fa-stack-exchange", '\uf18d');
            Icons.Add("fa-stack-overflow", '\uf16c');
            Icons.Add("fa-star", '\uf005');
            Icons.Add("fa-star-half", '\uf089');
            Icons.Add("fa-star-half-empty", '\uf123');
            Icons.Add("fa-star-half-full", '\uf123');
            Icons.Add("fa-star-half-o", '\uf123');
            Icons.Add("fa-star-o", '\uf006');
            Icons.Add("fa-steam", '\uf1b6');
            Icons.Add("fa-steam-square", '\uf1b7');
            Icons.Add("fa-step-backward", '\uf048');
            Icons.Add("fa-step-forward", '\uf051');
            Icons.Add("fa-stethoscope", '\uf0f1');
            Icons.Add("fa-sticky-note", '\uf249');
            Icons.Add("fa-sticky-note-o", '\uf24a');
            Icons.Add("fa-stop", '\uf04d');
            Icons.Add("fa-stop-circle", '\uf28d');
            Icons.Add("fa-stop-circle-o", '\uf28e');
            Icons.Add("fa-street-view", '\uf21d');
            Icons.Add("fa-strikethrough", '\uf0cc');
            Icons.Add("fa-stumbleupon", '\uf1a4');
            Icons.Add("fa-stumbleupon-circle", '\uf1a3');
            Icons.Add("fa-subscript", '\uf12c');
            Icons.Add("fa-subway", '\uf239');
            Icons.Add("fa-suitcase", '\uf0f2');
            Icons.Add("fa-sun-o", '\uf185');
            Icons.Add("fa-superpowers", '\uf2dd');
            Icons.Add("fa-superscript", '\uf12b');
            Icons.Add("fa-support", '\uf1cd');
            Icons.Add("fa-table", '\uf0ce');
            Icons.Add("fa-tablet", '\uf10a');
            Icons.Add("fa-tachometer", '\uf0e4');
            Icons.Add("fa-tag", '\uf02b');
            Icons.Add("fa-tags", '\uf02c');
            Icons.Add("fa-tasks", '\uf0ae');
            Icons.Add("fa-taxi", '\uf1ba');
            Icons.Add("fa-telegram", '\uf2c6');
            Icons.Add("fa-television", '\uf26c');
            Icons.Add("fa-tencent-weibo", '\uf1d5');
            Icons.Add("fa-terminal", '\uf120');
            Icons.Add("fa-text-height", '\uf034');
            Icons.Add("fa-text-width", '\uf035');
            Icons.Add("fa-th", '\uf00a');
            Icons.Add("fa-th-large", '\uf009');
            Icons.Add("fa-th-list", '\uf00b');
            Icons.Add("fa-themeisle", '\uf2b2');
            Icons.Add("fa-thermometer", '\uf2c7');
            Icons.Add("fa-thermometer-0", '\uf2cb');
            Icons.Add("fa-thermometer-1", '\uf2ca');
            Icons.Add("fa-thermometer-2", '\uf2c9');
            Icons.Add("fa-thermometer-3", '\uf2c8');
            Icons.Add("fa-thermometer-4", '\uf2c7');
            Icons.Add("fa-thermometer-empty", '\uf2cb');
            Icons.Add("fa-thermometer-full", '\uf2c7');
            Icons.Add("fa-thermometer-half", '\uf2c9');
            Icons.Add("fa-thermometer-quarter", '\uf2ca');
            Icons.Add("fa-thermometer-three-quarters", '\uf2c8');
            Icons.Add("fa-thumb-tack", '\uf08d');
            Icons.Add("fa-thumbs-down", '\uf165');
            Icons.Add("fa-thumbs-o-down", '\uf088');
            Icons.Add("fa-thumbs-o-up", '\uf087');
            Icons.Add("fa-thumbs-up", '\uf164');
            Icons.Add("fa-ticket", '\uf145');
            Icons.Add("fa-times", '\uf00d');
            Icons.Add("fa-times-circle", '\uf057');
            Icons.Add("fa-times-circle-o", '\uf05c');
            Icons.Add("fa-times-rectangle", '\uf2d3');
            Icons.Add("fa-times-rectangle-o", '\uf2d4');
            Icons.Add("fa-tint", '\uf043');
            Icons.Add("fa-toggle-down", '\uf150');
            Icons.Add("fa-toggle-left", '\uf191');
            Icons.Add("fa-toggle-off", '\uf204');
            Icons.Add("fa-toggle-on", '\uf205');
            Icons.Add("fa-toggle-right", '\uf152');
            Icons.Add("fa-toggle-up", '\uf151');
            Icons.Add("fa-trademark", '\uf25c');
            Icons.Add("fa-train", '\uf238');
            Icons.Add("fa-transgender", '\uf224');
            Icons.Add("fa-transgender-alt", '\uf225');
            Icons.Add("fa-trash", '\uf1f8');
            Icons.Add("fa-trash-o", '\uf014');
            Icons.Add("fa-tree", '\uf1bb');
            Icons.Add("fa-trello", '\uf181');
            Icons.Add("fa-tripadvisor", '\uf262');
            Icons.Add("fa-trophy", '\uf091');
            Icons.Add("fa-truck", '\uf0d1');
            Icons.Add("fa-try", '\uf195');
            Icons.Add("fa-tty", '\uf1e4');
            Icons.Add("fa-tumblr", '\uf173');
            Icons.Add("fa-tumblr-square", '\uf174');
            Icons.Add("fa-turkish-lira", '\uf195');
            Icons.Add("fa-tv", '\uf26c');
            Icons.Add("fa-twitch", '\uf1e8');
            Icons.Add("fa-twitter", '\uf099');
            Icons.Add("fa-twitter-square", '\uf081');
            Icons.Add("fa-umbrella", '\uf0e9');
            Icons.Add("fa-underline", '\uf0cd');
            Icons.Add("fa-undo", '\uf0e2');
            Icons.Add("fa-universal-access", '\uf29a');
            Icons.Add("fa-university", '\uf19c');
            Icons.Add("fa-unlink", '\uf127');
            Icons.Add("fa-unlock", '\uf09c');
            Icons.Add("fa-unlock-alt", '\uf13e');
            Icons.Add("fa-unsorted", '\uf0dc');
            Icons.Add("fa-upload", '\uf093');
            Icons.Add("fa-usb", '\uf287');
            Icons.Add("fa-usd", '\uf155');
            Icons.Add("fa-user", '\uf007');
            Icons.Add("fa-user-circle", '\uf2bd');
            Icons.Add("fa-user-circle-o", '\uf2be');
            Icons.Add("fa-user-md", '\uf0f0');
            Icons.Add("fa-user-o", '\uf2c0');
            Icons.Add("fa-user-plus", '\uf234');
            Icons.Add("fa-user-secret", '\uf21b');
            Icons.Add("fa-user-times", '\uf235');
            Icons.Add("fa-users", '\uf0c0');
            Icons.Add("fa-vcard", '\uf2bb');
            Icons.Add("fa-vcard-o", '\uf2bc');
            Icons.Add("fa-venus", '\uf221');
            Icons.Add("fa-venus-double", '\uf226');
            Icons.Add("fa-venus-mars", '\uf228');
            Icons.Add("fa-viacoin", '\uf237');
            Icons.Add("fa-viadeo", '\uf2a9');
            Icons.Add("fa-viadeo-square", '\uf2aa');
            Icons.Add("fa-video-camera", '\uf03d');
            Icons.Add("fa-vimeo", '\uf27d');
            Icons.Add("fa-vimeo-square", '\uf194');
            Icons.Add("fa-vine", '\uf1ca');
            Icons.Add("fa-vk", '\uf189');
            Icons.Add("fa-volume-control-phone", '\uf2a0');
            Icons.Add("fa-volume-down", '\uf027');
            Icons.Add("fa-volume-off", '\uf026');
            Icons.Add("fa-volume-up", '\uf028');
            Icons.Add("fa-warning", '\uf071');
            Icons.Add("fa-wechat", '\uf1d7');
            Icons.Add("fa-weibo", '\uf18a');
            Icons.Add("fa-weixin", '\uf1d7');
            Icons.Add("fa-whatsapp", '\uf232');
            Icons.Add("fa-wheelchair", '\uf193');
            Icons.Add("fa-wheelchair-alt", '\uf29b');
            Icons.Add("fa-wifi", '\uf1eb');
            Icons.Add("fa-wikipedia-w", '\uf266');
            Icons.Add("fa-window-close", '\uf2d3');
            Icons.Add("fa-window-close-o", '\uf2d4');
            Icons.Add("fa-window-maximize", '\uf2d0');
            Icons.Add("fa-window-minimize", '\uf2d1');
            Icons.Add("fa-window-restore", '\uf2d2');
            Icons.Add("fa-windows", '\uf17a');
            Icons.Add("fa-won", '\uf159');
            Icons.Add("fa-wordpress", '\uf19a');
            Icons.Add("fa-wpbeginner", '\uf297');
            Icons.Add("fa-wpexplorer", '\uf2de');
            Icons.Add("fa-wpforms", '\uf298');
            Icons.Add("fa-wrench", '\uf0ad');
            Icons.Add("fa-xing", '\uf168');
            Icons.Add("fa-xing-square", '\uf169');
            Icons.Add("fa-y-combinator", '\uf23b');
            Icons.Add("fa-y-combinator-square", '\uf1d4');
            Icons.Add("fa-yahoo", '\uf19e');
            Icons.Add("fa-yc", '\uf23b');
            Icons.Add("fa-yc-square", '\uf1d4');
            Icons.Add("fa-yelp", '\uf1e9');
            Icons.Add("fa-yen", '\uf157');
            Icons.Add("fa-yoast", '\uf2b1');
            Icons.Add("fa-youtube", '\uf167');
            Icons.Add("fa-youtube-play", '\uf16a');
            Icons.Add("fa-youtube-square", '\uf166');
        }
    }
}
