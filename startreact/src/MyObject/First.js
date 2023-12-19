import React from "react";

const UseServices = ({Tservice}) => {

    return(
        <div>
            <h1>un saluto (forse) casuale</h1>
            <h3>{Tservice.casualString}</h3>
        </div>
    )
}

function First() {
    return(
        <p>sono il primo componente react chiamato First</p>
    )    
}

export {First, UseServices}