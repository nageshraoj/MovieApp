import {
  ConfirmationNumber,
  Movie,
  LocalMovies,
  RecentActors,
  TheaterComedy,
  Settings,
  Logout,
} from "@mui/icons-material";
import {
  Box,
  Divider,
  List,
  ListItem,
  ListItemIcon,
  ListItemText,
  SwipeableDrawer,
} from "@mui/material";
import React, { useState } from "react";
import { Link } from "react-router-dom";

const SideDrawer = ({ open, setOpen, toggleDrawer }: any) => {
  //   const toggleDrawer = (open: boolean) => (
  //     event: React.KeyboardEvent | React.MouseEvent
  //   ) => {
  //     if (
  //       event &&
  //       event.type === "keydown" &&
  //       ((event as React.KeyboardEvent).key === "Tab" ||
  //         (event as React.KeyboardEvent).key === "Shift")
  //     ) {
  //       return;
  //     }

  //     setOpen(open);
  //   };

  const list = () => (
    <Box
      sx={{ auto: 250 }}
      role="presentation"
      onClick={toggleDrawer(false)}
      onKeyDown={toggleDrawer(false)}
    >
      <List>
        <ListItem button to="/" component={Link}>
          <ListItemIcon>
            <ConfirmationNumber />
          </ListItemIcon>
          <ListItemText primary="eTicket" />
        </ListItem>

        <ListItem button to="/movies" component={Link}>
          <ListItemIcon>
            <Movie />
          </ListItemIcon>
          <ListItemText primary="Movies" />
        </ListItem>
      </List>
      <Divider />
      <List>
        <ListItem button to="/cinema" component={Link}>
          <ListItemIcon>
            <LocalMovies />
          </ListItemIcon>
          <ListItemText primary="Cinemas" />
        </ListItem>

        <ListItem button to="/actors" component={Link}>
          <ListItemIcon>
            <RecentActors />
          </ListItemIcon>
          <ListItemText primary="Actors" />
        </ListItem>

        <ListItem button to="/producers" component={Link}>
          <ListItemIcon>
            <TheaterComedy />
          </ListItemIcon>
          <ListItemText primary="Producers" />
        </ListItem>
      </List>
      <Divider />
      <List>
        <ListItem button>
          <ListItemIcon>
            <Settings />
          </ListItemIcon>
          <ListItemText primary="Hello Admin" />
        </ListItem>

        <ListItem button>
          <ListItemIcon>
            <Logout />
          </ListItemIcon>
          <ListItemText primary="Logout" />
        </ListItem>
      </List>
    </Box>
  );

  return (
    <>
      <SwipeableDrawer
        open={open}
        onClose={toggleDrawer(false)}
        onOpen={toggleDrawer(true)}
      >
        {list()}
      </SwipeableDrawer>
    </>
  );
};

export default SideDrawer;
