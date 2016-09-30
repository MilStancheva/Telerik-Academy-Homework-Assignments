import { data } from 'data';
import { templateLoader } from './template-loader.js';

var router = (()=> {
    let router;

    function init(){
        router = new Navigo(null, true);

        router
            .on('#/', ()=> {
                $('#content').html('');
            })
            .on('#/threads/:id', (params) => {
                var id = params.id;
                Promise.all([data.threads.getById(id), templateLoader.get('messages')])
                    .then(function([data, template]){
                        let html = template(data);
                        $('#content').append(html);                    
                    })
                    .then( ()=> {
                        document.location = `#/threads/${id}`;
                    })
                    .catch((err) => showMsg(err, 'Error', 'alert-danger'));
            })
            .on('#/threads', ()=> {
                Promise.all([data.threads.get(), templateLoader.get('threads')])
                    .then(function([threads, template]){
                        let html = template(threads);
                        $('#content').html(html);
                    })
                    .then(()=> {
                        document.location = '#/threads';
                    })
                    .catch((err) => showMsg(err, 'Error', 'alert-danger'));
            })
            .on('#/threads/:id/messages', (params) => {
                var id = params.id,
                    content = $('#input-add-message').val();
                    console.log(id);
                    console.log(content);
                Promise.all([data.threads.addMessage(id, content), templateLoader.get('messages')])
                    .then(function([data, template]){
                        let html = template(data);
                        console.log(data);
                        console.log(html);
                        $('.messages panel-body').append(html);                                           
                    })
                    .then(() => {
                        $('.container-messages').html(""); 
                    })
                    .then( ()=> {
                        document.location = `#/threads/${id}`;
                    })
                    .catch((err) => showMsg(err, 'Error', 'alert-danger'));
            })
            .on('#/gallery', ()=> {
                Promise.all([data.gallery.get(), templateLoader.get('gallery')])
                    .then(function([data, template]){
                        let html = template(data);
                        $('#content').html(html);
                        })
                        .then(()=> {
                            document.location = '#/gallery';
                        })
                        .catch((err) => showMsg(err, 'Error', 'alert-danger'));
            })
            .resolve();
    }

    return {
        init
    };
})();

export { router };