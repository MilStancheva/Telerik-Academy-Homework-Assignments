var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key';

  // start users
  function userLogin(user) {
    localStorage.setItem(USERNAME_STORAGE_KEY, user);
    return Promise.resolve(user);
  }

  function userLogout() {
    localStorage.removeItem(USERNAME_STORAGE_KEY);
    return Promise.resolve();
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }
  // end users

  // start threads
  function threadsGet() {
    let promise = new Promise(function (resolve, reject) {
      $.getJSON("api/threads", function(threads){
        resolve(threads);
      });
    });
    return promise;
  }

  function threadsAdd(title) {
    var body;
    let promise = new Promise(function (resolve, reject) {      
        body = {
        title: JSON.stringify(title),
        username: localStorage.getItem(USERNAME_STORAGE_KEY)
      };

      $.ajax({
        url: 'api/threads',
        type: 'POST',
        data: JSON.stringify(body),
        contentType: 'application/json',
        headers: {
          "x-authkey": localStorage.getItem(USERNAME_STORAGE_KEY)
        },
        success: function (response) {
          resolve(response);
        }
      });
    });
    return promise;
  }

  function threadById(id) {
    let promise = new Promise(function (resolve, reject) {
      $.getJSON(`api/threads/${id}`, function (response) {
        resolve(response);
      });
    });
    return promise;

  }

  function threadsAddMessage(threadId, content) {
    var body = {
      username: localStorage.getItem(USERNAME_STORAGE_KEY),
      content: JSON.stringify(content)
    };
        
    let promise = new Promise((resolve, reject) => {
      $.ajax({
        url: `api/threads/${threadId}/messages`,
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(body),
        headers: {
          "x-authkey": localStorage.getItem(USERNAME_STORAGE_KEY)
        },
        success: (data) => {
          resolve(data);
        },
        error: (err) => reject(err)
      });
    });

    return promise;
  }
  // end threads

  // start gallery
  function galleryGet() {
    const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;

    return new Promise((resolve, reject) => {
      $.ajax({
        url: REDDIT_URL,
        dataType: 'jsonp'
      })
        .done(resolve)
        .fail(reject);
    });

  }
  // end gallery

  return {
    users: {
      login: userLogin,
      logout: userLogout,
      current: userGetCurrent
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadById,
      addMessage: threadsAddMessage
    },
    gallery: {
      get: galleryGet,
    }
  }
})();

export { data };