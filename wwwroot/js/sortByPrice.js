let sortOrder = "asc";
const sortBooksByPrice = () => {
    const table = document.getElementById("booksTable");
    const tableBody = document.getElementsByTagName("tbody")[0];
   
    const rows = Array.from(table.rows).slice(1);
    rows.sort((rowA, rowB) => {
        const priceA = parseFloat(rowA.cells[2].textContent);
        
        const priceB = parseFloat(rowB.cells[2].textContent);
        if (sortOrder === "asc") {
            return priceA - priceB;
        } else {
            return priceB - priceA;
        }
    });
    if (sortOrder === "asc") {
        sortOrder = "desc";
    } else {
        sortOrder = "asc";
    }
    rows.forEach(row => tableBody.appendChild(row));
}