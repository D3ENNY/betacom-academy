import React from "react";

class FirstWithClass extends React.Comment{
    constructor(props){
        super(props)
        this.state = {
            nominativo: "claudio orloff",
            employees: [],
        }
    }

    render() {
        const obj = this.state

        function GetEmployersName() {
            return obj.nominativo
        }

        return (
            <div>
                <h1> Membro della mitica accadey {GetEmployersName()} </h1>
            </div>
        )
    }
}

export default FirstWithClass