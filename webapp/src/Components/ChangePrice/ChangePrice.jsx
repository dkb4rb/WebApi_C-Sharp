import React from "react"
import "./ChangePrice.css"

const ChangePrice = () => {

    return (
        <>
            <div className="container-Price">
                <h1>Change Price</h1>
                <input name="Price" type="number" className="form-control" placeholder="Price"></input><br />  
            </div>
        </>
    )
}

export default ChangePrice;