import React from "react"
import "../CreateProp/CreateProperty.css"

const CreateOwner  = () => {

    return (
        <>
            <div className="container-create-prop">
                <h1>Crea un Owner </h1>
                <form >
                    <input name="Name" type="text" className="form-control" placeholder="Name"></input><br />
                    <input name="Address" type="text" className="form-control" placeholder="Name"></input><br />
                    <input name="Photo" type="file" className="form-control" placeholder="Name"></input><br />
                    <input name="Birthday" type="date" className="form-control" placeholder="Name"></input><br />

                </form>

            </div>
        </>
    )
}

export default CreateOwner;