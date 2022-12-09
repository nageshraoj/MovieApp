import React from "react";
import NavBar from "./NavBar";
import SideBar from "./SideBar";
import useMediaQuery from "@mui/material/useMediaQuery";

const Header = () => {
  const matches = useMediaQuery("(min-width:900px)");

  return <>{matches ? <NavBar /> : <SideBar />}</>;
};

export default Header;
