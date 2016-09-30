SystemJS.config({
 transpiler: 'plugin-babel',
 map: {
  'plugin-babel': 
  './node_modules/systemjs-plugin-babel/plugin-babel.js',
  'systemjs-babel-build': 
  './node_modules/systemjs-plugin-babel/systemjs-babel-browser.js',
  // app start script
  'main': './scripts/main.js',
  'data': './scripts/data.js'
 }
});