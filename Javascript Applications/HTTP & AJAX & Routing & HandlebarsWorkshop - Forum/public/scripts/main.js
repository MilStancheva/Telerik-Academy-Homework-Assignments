import {data} from 'data';
import { router } from './routing.js';

$(() => { // on document ready
  const GLYPH_UP = 'glyphicon-chevron-up',
    GLYPH_DOWN = 'glyphicon-chevron-down',
    root = $('#root'),
    navbar = root.find('nav.navbar'),
    mainNav = navbar.find('#main-nav'),
    contentContainer = $('#root #content'),
    loginForm = $('#login'),
    logoutForm = $('#logout'),
    usernameSpan = $('#span-username'),
    usernameInput = $('#login input'),
    alertTemplate = $($('#alert-template').text());

    router.init();

  (function checkForLoggedUser() {
    data.users.current()
      .then((user) => {
        if (user) {
          usernameSpan.text(user);
          loginForm.addClass('hidden');
          logoutForm.removeClass('hidden');
        }
      });
  })();

  function showMsg(msg, type, cssClass, delay) {
    let container = alertTemplate.clone(true)
      .addClass(cssClass).text(`${type}: ${msg}`)
      .appendTo(root);

    setTimeout(() => {
      container.remove();
    }, delay || 2000);
  }

  // start threads
  
  navbar.on('click', 'li', (ev) => {
    let $target = $(ev.target);
    $target.parents('nav').find('li').removeClass('active');
    $target.parents('li').addClass('active');
  });

  contentContainer.on('click', '#btn-add-thread', (ev) => {
    let title = $(ev.target).parents('form').find('#input-add-thread').val() || null;
    console.log(title);
    data.threads.add(title)
      .then(()=> {
          document.location = '#/threads';
        })
      .then(showMsg('Successfuly added the new thread', 'Success', 'alert-success'))
      .catch((err) => showMsg(JSON.parse(err.responseText).err, 'Error', 'alert-danger'));
  });

  contentContainer.on('click', 'a.thread-title', (ev) => {
    let $target = $(ev.target),
      threadId = $target.parents('.thread').attr('data-id');
      });

    $('.container-messages').text('');    

  contentContainer.on('click', '.btn-close-msg', (ev) => {
    let msgContainer = $(ev.target).parents('.container-messages').remove();
  });

  contentContainer.on('click', '.btn-collapse-msg', (ev) => {
    let $target = $(ev.target);
    if ($target.hasClass(GLYPH_UP)) {
      $target.removeClass(GLYPH_UP).addClass(GLYPH_DOWN);
    } else {
      $target.removeClass(GLYPH_DOWN).addClass(GLYPH_UP);
    }

    $target.parents('.container-messages').find('.messages').toggle();
  });
  // end threads

  // start login/logout
  navbar.on('click', '#btn-login', (ev) => {
    let username = usernameInput.val() || 'anonymous';
    data.users.login(username)
      .then((user) => {
        usernameInput.val('');
        usernameSpan.text(user);
        loginForm.addClass('hidden');
        logoutForm.removeClass('hidden');
      });
  });
  navbar.on('click', '#btn-logout', (ev) => {
    data.users.logout()
      .then(() => {
        usernameSpan.text('');
        loginForm.removeClass('hidden');
        logoutForm.addClass('hidden');
      });
  });
  // end login/logout
  
});