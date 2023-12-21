import { useEffect, useState } from "react";

const HookEmployeeData = (prop) => {

    const [employee, setEmployee] = useState("")

    useEffect(() => {
        fetch(`https://localhost:7210/api/AnagraficaGenerales/$(prop.phone.val)`, {method:"GET",})
        .then(r => {
            if(!r.ok) throw new Error("status code: "+r.status)
            return r.json()
        })
        .then((data) => setEmployee(data))
        .catch((error) => console.error("Error fetching employee:", error));
    },[prop.phone.val])

    return employee
}

export default HookEmployeeData