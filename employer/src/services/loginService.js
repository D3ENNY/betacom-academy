import { useEffect, useState } from "react";

const HookgetEmployee = (prop) => {

    const [employee, setEmployee] = useState("")

    useEffect(() => {
        fetch("https://localhost:7210/api/AnagraficaGenerales/"+prop.phone.val, {method:"GET",})
        .then(r => r.json())
        .then((data) => setEmployee(data))
    },[prop.phone.val])

    return employee
}

export default HookgetEmployee