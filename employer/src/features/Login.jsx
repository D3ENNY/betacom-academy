import React, { useState } from "react";
import HookgetEmployee from "../services/loginService";

const LoginPage = () => {

  const [phone, setPhone] = useState("")
  const [password, setPassword] = useState("")
  const [phoneError, setPhoneError] = useState("")
  const [passwordError, setPasswordError] = useState("")

  const onBtnClick = (event) => {
    event.preventDefault();
    setPhoneError("")
    setPasswordError("")

    if (phone === "") {
        setPhoneError("Please enter your phone number")
        return
    }

    if (!/^[\d]{10}$/.test(phone)) {
        setPhoneError("Please enter a valid email")
        return
    }


    if (password === "") {
        setPasswordError("Please enter a password")
        return
    }


    if (password.length < 7) {
        setPasswordError("The password must be 8 characters or longer")
        return
    }

    if(phoneError === "" && passwordError === ""){
      const employee = HookgetEmployee({phone: {val: phone}})
      
      if(password.trim() == employee.)
    }
  }

    return(
      <section className="vh-100">
        <div className="container py-5 h-100">
          <div className="row d-flex align-items-center justify-content-center h-100">
            <div className="col-md-8 col-lg-7 col-xl-6">
              <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg" className="img-fluid" alt="Phone" />
            </div>
            <div className="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
              <form>

                <div className="form-outline mb-4">
                  <input type="number" className="form-control form-control-lg"  onChange={ev => setPhone(ev.target.value)}/>
                  <label className="form-label" htmlFor="form1Example13">Phone number</label>
                  <label className="text-danger ms-2">{phoneError}</label>
                </div>

                <div className="form-outline mb-4">
                  <input type="password" id="form1Example23" className="form-control form-control-lg" onChange={ev => setPassword(ev.target.value)}/>
                  <label className="form-label" htmlFor="form1Example23">Password</label>
                  <label className="text-danger ms-2">{passwordError}</label>
                </div>
                <button className="btn btn-primary btn-lg btn-block" onClick={onBtnClick}>Sign in</button>
              </form>
            </div>
          </div>
        </div>
      </section>
    )
}

export default LoginPage