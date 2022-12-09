import React, { useState } from "react";
import {
  AppBar,
  Toolbar,
  Menu,
  MenuItem,
  TextField,
  Box,
  IconButton,
  Button,
} from "@mui/material";

import MenuIcon from "@mui/icons-material/Menu";
import { Link } from "react-router-dom";
import SideDrawer from "./SideDrawer";
import {
  Movie,
  Settings,
  Logout,
  AdminPanelSettings,
  SearchOutlined,
  KeyboardArrowDown,
  ConfirmationNumber,
} from "@mui/icons-material";

const NavBar = () => {
  const [anchor, setAnchar] = useState<null | Element>(null);
  const [open, setOpen] = useState<boolean>(false);
  const [navbarOpen, setNavBarOpen] = useState<boolean>(false);

  const onMenuOpen = (e: any) => {
    setAnchar(e.currentTarget);
    setOpen(true);
  };

  const onMenuClose = () => {
    setAnchar(null);
    setOpen(false);
  };

  const toggleDrawer = (navbarOpen: boolean) => (
    event: React.KeyboardEvent | React.MouseEvent
  ) => {
    if (
      event &&
      event.type === "keydown" &&
      ((event as React.KeyboardEvent).key === "Tab" ||
        (event as React.KeyboardEvent).key === "Shift")
    ) {
      return;
    }

    setNavBarOpen(navbarOpen);
  };

  return (
    <>
      <AppBar position="sticky" sx={{ top: "0px" }}>
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="open drawer"
            sx={{ mr: 2 }}
            onClick={() => setNavBarOpen(true)}
          >
            <MenuIcon />
          </IconButton>
          <Box sx={{ display: "flex", width: "100vw" }}>
            <Box
              sx={{
                padding: ".5rem",
                display: "flex",
              }}
            >
              <Button
                sx={{
                  margin: "auto",
                  color: "black",
                  borderRadius: "5px",
                  marginLeft: "5px",
                  "&:hover": {
                    backgroundColor: "#c0cb44",
                  },
                }}
                to="/"
                startIcon={<ConfirmationNumber fontSize="small" />}
                component={Link}
              >
                eTicket
              </Button>

              <Button
                sx={{
                  margin: "auto",
                  color: "black",
                  borderRadius: "5px",
                  marginLeft: "5px",
                  "&:hover": {
                    backgroundColor: "#c0cb44",
                  },
                }}
                startIcon={<Movie sx={{ fontSize: "small" }} />}
                to="/movies"
                component={Link}
              >
                Movies
              </Button>
              <Button
                // variant="contained"
                sx={{
                  margin: "auto",
                  color: "black",
                  border: "none",
                  borderRadius: "5px",
                  marginLeft: "5px",
                  "&:hover": {
                    backgroundColor: "#c0cb44",
                  },
                }}
                onClick={onMenuOpen}
                startIcon={<Settings />}
                endIcon={<KeyboardArrowDown />}
              >
                Management
              </Button>
            </Box>

            <Box
              sx={{
                padding: ".5rem",
                marginLeft: "auto",
                display: "flex",
              }}
            >
              <Box
                sx={{
                  // "&.MuiOutlinedInput-input": {
                  //   borderColor: "#fff",
                  // },

                  "& label.Mui-focused": {
                    color: "white",
                  },
                  "& .MuiInput-underline:after": {
                    borderBottomColor: "yellow",
                  },
                  "& .MuiOutlinedInput-root": {
                    "& fieldset": {
                      borderColor: "white",
                    },
                    "&:hover fieldset": {
                      borderColor: "white",
                    },
                    "&.Mui-focused fieldset": {
                      borderColor: "yellow",
                    },
                  },
                }}
              >
                <TextField
                  variant="outlined"
                  placeholder="Search for Movie"
                  size="small"
                  sx={{ borderColor: "#fff" }}
                  InputProps={{
                    endAdornment: (
                      <IconButton>
                        <SearchOutlined />
                      </IconButton>
                    ),
                  }}
                />
              </Box>

              <Button
                sx={{
                  margin: "auto",
                  borderRadius: "5px",
                  marginLeft: "5px",
                  color: "black",
                  "&:hover": {
                    backgroundColor: "#c0cb44",
                  },
                }}
                startIcon={<AdminPanelSettings />}
                to="/movies"
                component={Link}
              >
                Hello Admin
              </Button>

              <Button
                sx={{
                  margin: "auto",
                  borderRadius: "5px",
                  color: "black",
                  marginLeft: "5px",
                  "&:hover": {
                    backgroundColor: "#c0cb44",
                  },
                }}
                startIcon={<Logout />}
                to="/movies"
                component={Link}
              >
                {" "}
                Logout
              </Button>
            </Box>
          </Box>
        </Toolbar>
      </AppBar>
      <Menu
        open={open}
        onMouseLeave={onMenuClose}
        anchorEl={anchor}
        onClick={onMenuClose}
      >
        <MenuItem to="/cinema" component={Link}>
          Cinemas
        </MenuItem>
        <MenuItem to="/actors" component={Link}>
          Actors
        </MenuItem>
        <MenuItem to="/producers" component={Link}>
          Producers
        </MenuItem>
      </Menu>
      <SideDrawer
        open={navbarOpen}
        setNavBarOpen={navbarOpen}
        toggleDrawer={toggleDrawer}
      />
    </>
  );
};

export default NavBar;
