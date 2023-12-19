import React, { useEffect, useState } from "react";

const HookGetData = () => {
    const [state, setState] = useState({
        jsData: []
    })

    useEffect(() => {
        fetch('https://jsonplaceholder.typicode.com/todos')
        .then((response) => response.json())
        .then((json) => (
            setState((prevState) => ({...prevState, jsData: json}))
        ))
    }, [])

    const {jsData} = state
    return (
        <div>
            <h1>Hook</h1>
            {jsData.map((x) => (
                <div>
                    ID {x.id}
                    Title {x.title}
                </div>
            ))}
        </div>
    )

}

export default HookGetData