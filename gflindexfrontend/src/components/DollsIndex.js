import styles from './dollsindex.module.css';

export default function DollsIndex(props) {
    return (
        <div>
            <table className='table table-striped' aria-labelledby='tableLabel'>
                <thead>
                    <tr className={styles.tableHeadings}>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Rarity</th>
                        <th>Type</th>
                    </tr>
                </thead>
                <tbody>
                    {props.data.map(doll =>
                        <tr key={doll.id} className={styles.tableEntries}>
                            <td>{doll.id}</td>
                            <td>{doll.name}</td>
                            <td>{doll.rarity.rarity}</td>
                            <td>{doll.type.name}</td>
                            <td><button onClick={() => props.changeRoute('api/dolls/' + doll.id)}>Details</button></td>
                        </tr>
                    )}
                </tbody>
            </table>
        </div>
    );
}