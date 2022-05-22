import React from "react"
import "./CreateProperty.css"

const CreateProp  = () => {

    return (
        <>
            <div className="container-create-prop">
                <h1>Crea una prop </h1>
                <form >
                    <input name="Name" type="text" className="form-control" placeholder="Name"></input><br />
                    <input name="Address" type="text" className="form-control" placeholder="Address"></input><br />
                    <input name="Price" type="number" className="form-control" placeholder="Price"></input><br />
                    <input name="CodeInternal" type="number" className="form-control" placeholder="CodeInternal"></input><br />
                    <input name="Year" type="date" className="form-control" placeholder="Year"></input><br />

                </form>

            </div>
        </>
    )
}

export default CreateProp;