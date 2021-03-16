import React from 'react';
import ReactDOM from 'react-dom'; //To render
import './css/index.css';
import './login';
//SPA route
//import {BrowserRouter, Route, Switch} from 'react-router-dom'

import reportWebVitals from './reportWebVitals';
import Header from './Header';
import Client from './clients';
//import { Link } from 'react-router'; //Para añadir rutas
import {BrowserRouter as Router, Route} from "react-router-dom";

ReactDOM.render(
    <Router>
        <div>
            <Route exact path="/">
                <Header/>
            </Route>
            <Route exact path="/client">
                <Client/>
            </Route>
        </div>
    </Router>,
    document.getElementById('root')
);


reportWebVitals();
