import React from 'react';
import ReactDOM from 'react-dom'; //To render
import './css/index.css';

//SPA route
import {BrowserRouter, Route, Switch} from 'react-router-dom'

import reportWebVitals from './reportWebVitals';
import Header from './Header';
import Client from './cliente';
//import { Link } from 'react-router'; //Para añadir rutas

ReactDOM.render(
   /* <Router history={BrowserRouter}>
        <Route path="/" component={Header}/>
        <Route path="/cliente" component={Cliente}/>
    </Router>*/
    /*    <BrowserRouter>
            <Switch>
                <Route exact path="/" component={Header}/>
                <Route path="/cliente" component={Client}/>
            </Switch>
        </BrowserRouter>,*/
     <React.StrictMode>
            <Header/>
        </React.StrictMode>,

    document.getElementById('root')
);


reportWebVitals();
