import React from 'react';
import ReactDOM from 'react-dom'; //To render
import './css/index.css';


import reportWebVitals from './reportWebVitals';
import Header from './Header';
import Login from "./Login";
/*import Login from './Login';*/

import {BrowserRouter as Router, Route} from "react-router-dom";


ReactDOM.render(
    <Router>
        <div>
            <Route exact path="/">
                <Header/>
            </Route>

            <Route exact path="/users/login">
                <Login/>
            </Route>
        </div>
    </Router>,
    document.getElementById('root')
);


reportWebVitals();
