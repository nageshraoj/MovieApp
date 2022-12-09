import axios from "axios";
import React, { useState, useEffect } from "react";
import {
  TableContainer,
  Paper,
  Table,
  TableBody,
  TableHead,
  TableRow,
  TableCell,
  Box,
  Button,
  ButtonGroup,
  Container,
} from "@mui/material";
import { Edit, Delete, Visibility } from "@mui/icons-material";

const Actors = () => {
  const [actors, setActors] = useState<any>();

  useEffect(() => {
    const getActors = async () => {
      const { data }: any = await axios.get("http://localhost:5005/api/Actor");
      setActors(data);
      return data;
    };
    getActors();
  }, []);

  return (
    <>
      <Container>
        <TableContainer component={Paper}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>Image</TableCell>
                <TableCell>Name</TableCell>
                <TableCell>Bio</TableCell>
                <TableCell>Actions</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {actors?.map((item: any, index: any) => (
                <TableRow key={index}>
                  <TableCell>
                    <Box
                      component="img"
                      sx={{
                        height: 100,
                        width: 100,
                        borderRadius: 50,
                        maxHeight: { xs: 233, md: 167 },
                        maxWidth: { xs: 350, md: 250 },
                      }}
                      alt="The house from the offer."
                      src={item.profilePictureURL}
                    />
                  </TableCell>
                  <TableCell>{item.name}</TableCell>
                  <TableCell>{item.bio}</TableCell>
                  <TableCell>
                    <ButtonGroup>
                      <Button
                        sx={{
                          borderColor: "#7FE9DE",
                          borderRadius: "5px",
                          "&:active": {
                            transform: "scale(.9)",
                          },
                        }}
                        startIcon={<Edit />}
                      >
                        Edit
                      </Button>
                      <Button
                        sx={{
                          borderColor: "green",
                          borderRadius: "5px",
                          "&:active": {
                            transform: "scale(.9)",
                          },
                        }}
                        startIcon={<Visibility />}
                      >
                        View
                      </Button>
                      <Button
                        variant="contained"
                        sx={{
                          backgroundColor: "#FF7000",
                          borderRadius: "5px",
                          "&:hover": {
                            backgroundColor: "#FF7000",
                          },
                          "&:active": {
                            transform: "scale(.9)",
                          },
                        }}
                        startIcon={<Delete />}
                      >
                        Delete
                      </Button>
                    </ButtonGroup>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </Container>
    </>
  );
};

export default Actors;
