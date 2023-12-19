import React from "react";

class FirstWithClass extends React.Comment{
    constructor(props){
        super(props)
        this.state = {
            nominativo: "claudio orloff",
            employees: [],
        }
    }

    GetEmployersName() {
        return this.state.nominativo
    }

    render() {

        return (
            <div>
                <h1> Membro della mitica accadey {this.GetEmployersName()} </h1>
            </div>
        )
    }
}

export default FirstWithClass