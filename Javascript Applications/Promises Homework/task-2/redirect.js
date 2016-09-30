(function(){    
    let promise = new Promise((resolve, reject) => {
           resolve(document.getElementById('popup'));
        });

    function redirect() {
        window.setTimeout(() => { window.location = "https://telerikacademy.com/"; }, 2000);
    }

    promise
        .then(redirect)
        .catch();
}());