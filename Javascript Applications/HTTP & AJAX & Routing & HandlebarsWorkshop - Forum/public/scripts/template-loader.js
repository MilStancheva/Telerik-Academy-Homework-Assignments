const templateLoader = (()=> {
const cache = {};

    function get(templateName){
        var promise = new Promise((resolve, reject)=>{
            if(cache[templateName]){
                resolve(cache[templateName]);
                return;
            }
            else {
                
        $.get(`/scripts/templates/${templateName}.handlebars`)
            .done((data) => {
              let template = Handlebars.compile(data);
              cache[templateName] = template;
              resolve(template);
            })
            .fail(reject);
            }
        });
        
        return promise;
    }

return{
    get
};
})();

export { templateLoader };