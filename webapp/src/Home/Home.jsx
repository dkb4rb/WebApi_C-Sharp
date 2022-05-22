import React from "react";
import CreateProp from "../Components/CreateProp/CreateProperty";
import ChangePrice from "../Components/ChangePrice/ChangePrice";
import AddImage from "../Components/AddImage/AddImage";
import UpdateViews from "../Components/UpdateView/UpdateViews";
import ListProp from "../Components/ListProp/ListProp";
import CreateOwner from "../Components/CreateOwner/CreateOwner";
import Header from "../Components/Header/Header";

const Home = () => {
  return (
    <>
      <div>
        <Header />
        <CreateOwner></CreateOwner>
        <CreateProp> </CreateProp>
        <ChangePrice></ChangePrice>
        <AddImage />
        <UpdateViews />
        <ListProp />
      </div>
    </>
  );
};

export default Home;
