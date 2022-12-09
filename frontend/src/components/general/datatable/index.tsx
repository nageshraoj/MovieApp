import React from "react";
import { TableContainer, TableHead, TableRow, TableCell } from "@mui/material";

const DataTable = ({ tablehead, tablebody }: any) => {
  return (
    <>
      <TableContainer>
        <TableHead>
          <TableRow>
            {tablehead.map((item: any, index: any) => (
              <TableCell key={index}>{item} </TableCell>
            ))}
          </TableRow>
        </TableHead>
      </TableContainer>
    </>
  );
};

export default DataTable;
