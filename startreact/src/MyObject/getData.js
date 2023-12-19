import React from "react";

class GetData extends React.Component{

    constructor(props){
        super(props)
        this.state = {
            placeholderObj: []
        }
    }

    componentDidMount(){
        fetch('https://jsonplaceholder.typicode.com/todos')
        .then((response) => response.json())
        .then((json) => {
            console.log(json)
            this.setState({placeholderObj: json})
        })
    }

    render(){
        const {placeholderObj} = this.state
        return (
            <div>
                <h1>data da JSONPlasceholder</h1>
                {placeholderObj.map((x) => (
                    <div>
                        ID {x.id}
                        Title {x.title}
                    </div>
                ))}
            </div>
        )
    }

}

export default GetData