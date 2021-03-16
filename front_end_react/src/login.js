import React from "react";
import './css/login.css';

function Login(props) {
    return (props.trigger) ? (
        <div className="modal-contents">
            <form>
                <label>
                    User:
                    <input type="text" name="username"/>
                </label>
                <label>
                    Password:
                    <input type="text" name="password"/>
                </label>
                <input type="submit" value="Submit"/>
            </form>
        </div>) : "";
}