module.exports = {
  devtool: 'eval',
  devServer: {contentBase: __dirname + '/public', host: '0.0.0.0', port: 3000},
  entry: './dist',
  output: {filename: 'app.min.js', path: `${__dirname}/public`},
  performance: {hints: false},
  mode: 'development'
};
