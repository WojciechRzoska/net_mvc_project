const searchBooks = () => {
    const searchTerm = document.getElementById("searchTerm").value.toLowerCase();
    const table = document.getElementById("booksTable");
    const rows = Array.from(table.rows).slice(1);
    rows.forEach(row => {
        const titleCell = row.cells[0];
        const title = titleCell.textContent.toLowerCase();
        if (title.includes(searchTerm)) {
            row.style.display = "table-row";
        } else {
            row.style.display = "none";
        }
    });
}