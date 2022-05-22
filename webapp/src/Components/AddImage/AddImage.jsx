import React from "react";
import "./AddImage.css";
const AddImage = () => {
  return (
    <>
      <div className="container-Img">
        <h1>Add Image</h1>
        <input
          name="file"
          type="file"
          className="form-control"
          placeholder="Name"
        ></input>
        <br />
        <div class="input-group-text">
          <input
            class="form-check-input mt-0"
            type="checkbox"
            value="Enable"
            aria-label="Checkbox for following text input"
          ></input>
          Enable
        </div>
        <div class="input-group-text">
          <input
            class="form-check-input mt-0"
            type="checkbox"
            value="Disable"
            aria-label="Checkbox for following text input"
          ></input>
          Disable
        </div>
        <br />
      </div>
    </>
  );
};
export default AddImage;
