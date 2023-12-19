import React from "react";

const App = (props) => {

    const {loggedIn, email} = props

    const onBtnClick = () => {

    }

    return(
<div className="mainContainer">

        <div>
            <div>Welcome!</div>
        </div>
        <div>
            This is the home page.
        </div>
        <div>
            <input type="button" onClick={onBtnClick} value={loggedIn ? "Log out" : "Log in"} />
            {(loggedIn ? <div> Your email address is {email} </div> : <div/>)}
        </div>
    </div>
    )
}

export default App