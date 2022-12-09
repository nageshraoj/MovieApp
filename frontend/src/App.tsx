import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Header from "./components/Header/index";
import Movies from "./components/pages/movies";
import Actors from "./components/pages/actors/index";
import Producers from "./components/pages/producers/index";
import { Global, css } from "@emotion/react";
import Cinema from "./components/pages/cinema/index";

const App = () => {
  return (
    <>
      <Global
        styles={css`
          body {
            margin: 0px;
            padding: 0px;
            width: 100vw;
            height: 100vh;
          }
        `}
      />
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path="/home" element={<Movies />} />
          <Route path="/cinema" element={<Cinema />} />
          <Route path="/actors" element={<Actors />} />
          <Route path="/producers" element={<Producers />} />
          <Route path="/*" element={<Movies />} />
        </Routes>
      </BrowserRouter>
    </>
  );
};

export default App;
